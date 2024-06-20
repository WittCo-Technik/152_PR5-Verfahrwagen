using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Tesseract;
using System.Windows;

namespace EB_Erkennung
{
    public partial class ImageForm : Form
    {
        public ImageForm()
        {
            InitializeComponent();
            SetPicture();
        }
        private void SetPicture()
        {
            if (GlobalData.LoadedImage != null)
            {
                pictureBox1.Image = GlobalData.LoadedImage;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.gif,*.png)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imagePath = openFileDialog.FileName;
                    System.Drawing.Image originalImage = System.Drawing.Image.FromFile(imagePath);

                    int maxWidth = 800;
                    int maxHeight = 800;

                    int newWidth = originalImage.Width;
                    int newHeight = originalImage.Height;

                    if (originalImage.Width > maxWidth || originalImage.Height > maxHeight)
                    {
                        double aspectRatio = (double)originalImage.Width / originalImage.Height;

                        if (aspectRatio > 1)
                        {
                            newWidth = maxWidth;
                            newHeight = (int)(maxWidth / aspectRatio);
                        }
                        else
                        {
                            newHeight = maxHeight;
                            newWidth = (int)(maxHeight * aspectRatio);
                        }
                    }

                    pictureBox1.Image = new Bitmap(originalImage, newWidth, newHeight);
                    GlobalData.LoadedImage = pictureBox1.Image;
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show($"Fehler beim Laden des Bildes: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RecognizeText(GlobalData.LoadedImage, GlobalData.IbcList);
        }
        private void RecognizeText(System.Drawing.Image image, List<IBC> ibcList)
        {
            if (image == null)
            {
                System.Windows.Forms.MessageBox.Show("Kein Bild zum Erkennen von Text geladen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ibcList == null || ibcList.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Die IBC-Liste ist leer oder nicht initialisiert.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                GlobalData.LoadedImage.Save("processed_image.png");

                using (var loadedImage = SixLabors.ImageSharp.Image.Load<Rgba32>("processed_image.png"))
                {
                    loadedImage.Mutate(x => x.Contrast(0.8f)); // Erhöht den Kontrast des Bildes
                    loadedImage.Mutate(x => x.Brightness(1)); // Verringert die Helligkeit des Bildes
                    var scaleFactor = 2f; // Beispiel: Skalierung um 200%
                    var newWidth = (int)(loadedImage.Width * scaleFactor);
                    var newHeight = (int)(loadedImage.Height * scaleFactor);
                    loadedImage.Mutate(x => x.Resize(newWidth, newHeight)); // Skaliert das Bild
                    loadedImage.Mutate(x => x.GaussianSharpen(3)); // Den Wert ggf. anpassen

                    loadedImage.Save("processed_image.png"); // Speichert das verarbeitete Bild
                }

                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                string tessdataDirectory = Path.Combine(projectDirectory, "tessdata");
                string testDirectory = Path.Combine(projectDirectory, "Test_Data");

                using (var engine = new TesseractEngine(tessdataDirectory, "deu", EngineMode.Default))
                {
                    engine.DefaultPageSegMode = PageSegMode.SparseText;

                    using (var img = Pix.LoadFromFile("processed_image.png"))
                    {
                        using (var page = engine.Process(img))
                        {
                            string recognizedText = page.GetText();
                            System.Windows.Forms.MessageBox.Show("Erkannter Text: " + recognizedText);

                            // Erstelle den Pfad für die Textdatei im selben Ordner
                            string textFilePath = Path.Combine(testDirectory, "erkannter_text.txt");

                            // Speichern des erkannten Textes in der Datei
                            File.WriteAllText(textFilePath, recognizedText);
                            System.Windows.Forms.MessageBox.Show($"Erkannter Text wurde in Test_Data gespeichert.", "Text Gespeichert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Initialisierung von foundIBC mit null
                            IBC foundIBC = null;

                            foundIBC = FindFirstMatchingIBC(recognizedText, ibcList);

                            if (foundIBC != null)
                            {
                                DisplayIBCInfo(foundIBC);
                                GlobalData.FoundIBC = foundIBC;
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("Kein passender IBC-Eintrag gefunden.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Fehler bei der Texterkennung: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private IBC FindFirstMatchingIBC(string recognizedText, List<IBC> ibcList)
        {
            string pText = ProcessString(recognizedText);
            System.Windows.Forms.MessageBox.Show(pText);

            // Zuerst nach einer exakten Übereinstimmung suchen
            IBC exactMatchIBC = ibcList.FirstOrDefault(ibc => ExactMatch(pText, ProcessString(ibc.Bezeichnung + ibc.LangText)));

            if (exactMatchIBC != null)
            {
                return exactMatchIBC;
            }

            // Wenn keine exakte Übereinstimmung gefunden wurde, den besten Match suchen
            IBC foundIBC = null;
            int maxMatchLength = 0;

            foreach (var ibc in ibcList)
            {
                // Zusammensetzen von Bezeichnung und Langtext
                string fullText = ProcessString(ibc.Bezeichnung + ibc.LangText);

                // Finden der längsten aufeinanderfolgenden Teilzeichenfolge in pText
                int matchLength = LongestConsecutiveSubstring(pText, fullText);

                // Wenn die Länge der Übereinstimmung größer ist als bisher gefunden
                if (matchLength > maxMatchLength)
                {
                    maxMatchLength = matchLength;
                    foundIBC = ibc;
                }
            }

            return foundIBC;
        }
        private bool ExactMatch(string pattern, string text)
        {
            // Prüfe, ob der pattern exakt im text vorkommt
            return text.Contains(pattern);
        }
        private int LongestConsecutiveSubstring(string pattern, string text)
        {
            int maxMatchLength = 0;

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 1; j <= text.Length - i; j++)
                {
                    string subText = text.Substring(i, j);
                    if (pattern.Contains(subText))
                    {
                        // Überprüfen, ob die Teilzeichenfolge in pattern aufeinanderfolgend ist
                        if (IsConsecutiveSubstring(subText, pattern))
                        {
                            maxMatchLength = Math.Max(maxMatchLength, subText.Length);
                        }
                    }
                    else
                    {
                        break; // Da pattern nicht subText enthält, brechen wir die Schleife ab
                    }
                }
            }

            return maxMatchLength;
        }
        private bool IsConsecutiveSubstring(string subText, string text)
        {
            // Um zu prüfen, ob subText eine aufeinanderfolgende Teilzeichenfolge in text ist,
            // müssen wir die Positionen von subText in text finden und überprüfen, ob sie aufeinanderfolgend sind
            int index = -1;

            foreach (char c in subText)
            {
                index = text.IndexOf(c, index + 1);
                if (index == -1)
                {
                    return false; // Der aktuelle Buchstabe in subText wurde nicht in text gefunden
                }
            }

            return true; // Alle Buchstaben in subText wurden in text gefunden und sind aufeinanderfolgend
        }
        private string ProcessString(string text)
        {
            // Umwandeln in Kleinbuchstaben
            text = text.ToLower();

            // Entfernen von Leerzeichen
            text = Regex.Replace(text, @"\s+", "");

            // Liste der zu entfernenden Wörter
            string[] wordsToRemove = { "produkt", "product", "gefahr", "danger", "flammableliquid", "corrosive" };

            // Entfernen der Wörter
            foreach (string word in wordsToRemove)
            {
                text = text.Replace(word, "");
            }

            return text;
        }
        private static void DisplayIBCInfo(IBC ibc)
        {
            if (ibc == null)
            {
                System.Windows.Forms.MessageBox.Show("Keine Informationen für den gefundenen IBC verfügbar.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            System.Windows.Forms.MessageBox.Show($"ArtikelNummer: {ibc.ArtikelNummer} {Environment.NewLine} Warengruppe: {ibc.WarenGruppenNummer} {Environment.NewLine} MatchCode: {ibc.MatchCode} {Environment.NewLine} Bezeichnung: {ibc.Bezeichnung} {Environment.NewLine} LangText: {ibc.LangText} {Environment.NewLine}" +
            $" Blasenwechsel: {ibc.K_Blasenwechsel} {Environment.NewLine} Waschbar: {ibc.K_Waschbar} {Environment.NewLine} Selbsteinstufung: {ibc.K_Selbsteinstufung} {Environment.NewLine} Neutralisation/Sperrlager: {ibc.K_NeutralisationSperrlager} {Environment.NewLine} UNNummer: {ibc.K_UNNummer} {Environment.NewLine} Verschmutzungsgrad in %: {ibc.K_VerschmutzungsgradProzent}", "IBC-Informationen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonQR_Click(object sender, EventArgs e)
        {
            
        }

        


    }
}

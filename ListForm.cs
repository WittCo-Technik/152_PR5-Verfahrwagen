using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace EB_Erkennung
{

    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            if (GlobalData.IbcList != null)
            {
                UpdateDataGridView();
            }
        }
        private void ButtonXmlUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string xmlFilePath = openFileDialog.FileName;
                GlobalData.IbcList = ReadXmlData(xmlFilePath);
                UpdateDataGridView();
            }
        }
        private static List<IBC> ReadXmlData(string xmlFilePath)
        {
            List<IBC> ibcList = new List<IBC>();

            // Open the XML file with the correct encoding
            using (StreamReader reader = new StreamReader(xmlFilePath, Encoding.GetEncoding("Windows-1252")))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(reader);

                XmlNodeList rows = xmlDoc.DocumentElement.ChildNodes;

                foreach (XmlNode row in rows)
                {
                    IBC ibc = new IBC();
                    ibc.ArtikelNummer = row.SelectSingleNode("ArtikelNummer")?.InnerText;
                    ibc.WarenGruppenNummer = row.SelectSingleNode("WarenGruppenNummer")?.InnerText;
                    ibc.MatchCode = row.SelectSingleNode("MatchCode")?.InnerText;
                    ibc.Bezeichnung = row.SelectSingleNode("Bezeichnung")?.InnerText;
                    ibc.LangText = row.SelectSingleNode("LangText")?.InnerText;
                    ibc.K_Blasenwechsel = row.SelectSingleNode("K_Blasenwechsel")?.InnerText;
                    ibc.K_Selbsteinstufung = row.SelectSingleNode("K_Selbsteinstufung")?.InnerText;
                    ibc.K_Waschbar = row.SelectSingleNode("K_Waschbar")?.InnerText;
                    ibc.K_NeutralisationSperrlager = row.SelectSingleNode("K_NeutralisationSperrlager")?.InnerText;
                    ibc.K_UNNummer = row.SelectSingleNode("K_UNNummer")?.InnerText;
                    ibc.K_VerschmutzungsgradProzent = row.SelectSingleNode("K_VerschmutzungsgradProzent")?.InnerText;

                    ibcList.Add(ibc);
                }
            }

            return ibcList;
        }
        private void UpdateDataGridView()
        {
            dataGridViewXML.DataSource = GlobalData.IbcList; // Set the data source to the updated list
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchKeyword = textBoxSearch.Text.ToLower(); // Hole den Suchbegriff aus der TextBox und wandele ihn in Kleinbuchstaben um
            List<IBC> filteredIbcList = new List<IBC>();

            // Durchlaufe die gesamte IbcList und füge die Einträge hinzu, die den Suchbegriff enthalten
            foreach (var ibc in GlobalData.IbcList)
            {
                if (ContainsSearchKeyword(ibc, searchKeyword))
                {
                    filteredIbcList.Add(ibc);
                }
            }

            // Aktualisiere das DataGridView mit den gefilterten Ergebnissen
            dataGridViewXML.DataSource = filteredIbcList;
        }
        private bool ContainsSearchKeyword(IBC ibc, string searchKeyword)
        {
            // Überprüfe, ob einer der Eigenschaften des IBC den Suchbegriff enthält
            return (ibc.ArtikelNummer != null && ibc.ArtikelNummer.ToLower().Contains(searchKeyword))
                || (ibc.WarenGruppenNummer != null && ibc.WarenGruppenNummer.ToLower().Contains(searchKeyword))
                || (ibc.MatchCode != null && ibc.MatchCode.ToLower().Contains(searchKeyword))
                || (ibc.Bezeichnung != null && ibc.Bezeichnung.ToLower().Contains(searchKeyword))
                || (ibc.LangText != null && ibc.LangText.ToLower().Contains(searchKeyword))
                || (ibc.K_Blasenwechsel != null && ibc.K_Blasenwechsel.ToLower().Contains(searchKeyword))
                || (ibc.K_Selbsteinstufung != null && ibc.K_Selbsteinstufung.ToLower().Contains(searchKeyword))
                || (ibc.K_Waschbar != null && ibc.K_Waschbar.ToLower().Contains(searchKeyword))
                || (ibc.K_NeutralisationSperrlager != null && ibc.K_NeutralisationSperrlager.ToLower().Contains(searchKeyword))
                || (ibc.K_UNNummer != null && ibc.K_UNNummer.ToLower().Contains(searchKeyword))
                || (ibc.K_VerschmutzungsgradProzent != null && ibc.K_VerschmutzungsgradProzent.ToLower().Contains(searchKeyword));
        }
    }
}

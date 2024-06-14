using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EB_Erkennung
{
    public partial class CloudForm : Form
    {
        public CloudForm()
        {
            InitializeComponent();
            UpdateTextBoxes();
        }

        private void UpdateTextBoxes()
        {
            if (GlobalData.FoundIBC != null)
            {
                textBox2.Text = GlobalData.FoundIBC.ArtikelNummer;
                textBox1.Text = GlobalData.FoundIBC.WarenGruppenNummer;
                txtMatchCode.Text = GlobalData.FoundIBC.MatchCode;
                textBezeichnung.Text = GlobalData.FoundIBC.Bezeichnung;
                textBoxLangText.Text = GlobalData.FoundIBC.LangText;
                textBW.Text = GlobalData.FoundIBC.K_Blasenwechsel;
                textWB.Text = GlobalData.FoundIBC.K_Waschbar;
                textBoxSelbsteinstufung.Text = GlobalData.FoundIBC.K_Selbsteinstufung;
                textNS.Text = GlobalData.FoundIBC.K_NeutralisationSperrlager;
                textUN.Text = GlobalData.FoundIBC.K_UNNummer;
                textVer.Text = GlobalData.FoundIBC.K_VerschmutzungsgradProzent;
            }
        }

        private async Task<string> GetAccessToken()
        {
            var options = new RestClientOptions("https://login.microsoftonline.com")
            {
                Timeout = TimeSpan.FromMilliseconds(-1),
            };
            var client = new RestClient(options);
            var request = new RestRequest("/awico.com/oauth2/v2.0/token", Method.Post);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Cookie", "fpc=Ail_AlFl9ZdGipOIhnJrlTwdOmi5AQAAAHqYod0OAAAA; stsservicecookie=estsfd; x-ms-gateway-slice=estsfd");
            request.AddParameter("client_id", "61e285ff-aaeb-4c9f-9315-135dad1a43d2");
            request.AddParameter("client_secret", "U.Xj1fJTM44oFYbcs8~BQag~Lj~216-f73");
            request.AddParameter("scope", "https://api.businesscentral.dynamics.com//.default");
            request.AddParameter("grant_type", "password");
            request.AddParameter("username", "workflow@awico.com");
            request.AddParameter("password", "Xub28466");

            RestResponse response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                var json = JObject.Parse(response.Content);
                var accessToken = json["access_token"]?.ToString();
                if (!string.IsNullOrEmpty(accessToken))
                {
                    textCloud.Text = accessToken;
                    return accessToken;
                }
                else
                {
                    // Zugriffstoken konnte nicht extrahiert werden
                    textCloud.Text = "Token konnte nicht extrahiert werden: " + response.Content;
                    return null;
                }
            }
            else
            {
                // HTTP-Anfrage fehlgeschlagen
                textCloud.Text = "Fehler beim Abrufen des Tokens: " + response.ErrorMessage;
                return null;
            }
        }

        private async Task PostIBC(string accessToken)
        {
            // Konfiguration des REST-Clients
            var options = new RestClientOptions("https://api.businesscentral.dynamics.com")
            {
                Timeout = TimeSpan.FromMilliseconds(-1),
            };

            var client = new RestClient(options);
            var request = new RestRequest("/v2.0/awico.com/sandbox/api/awico/ibc/v1.0/companies(7ec3e635-78f1-ea11-bb45-000d3a239fb3)/container?$expand=plates,labels", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "Bearer " + accessToken);

            if (GlobalData.FoundIBC == null)
            {
                MessageBox.Show("Kein IBC gefunden");
                return;
            }

            // Umwandlung der Werte '0' und '1' in boolesche Werte
            bool K_Blasenwechsel = GlobalData.FoundIBC.K_Blasenwechsel == "1";
            bool K_NeutralisationSperrlager = GlobalData.FoundIBC.K_NeutralisationSperrlager == "1";
            bool K_Waschbar = GlobalData.FoundIBC.K_Waschbar == "1";

            var body = $@"
            {{
                ""serialNo"": ""{GlobalData.FoundIBC.WarenGruppenNummer}"",
                ""itemNo"": ""{GlobalData.FoundIBC.ArtikelNummer}"",
                ""bladProductName"": ""{GlobalData.FoundIBC.Bezeichnung} {GlobalData.FoundIBC.LangText}"",
                ""bladProductUNNumber"": ""{GlobalData.FoundIBC.K_UNNummer}"",
                ""bladProductBladReplace"": {K_Blasenwechsel.ToString().ToLower()},
                ""bladProductNeutralization"": {K_NeutralisationSperrlager.ToString().ToLower()},
                ""bladProductWashable"": {K_Waschbar.ToString().ToLower()}
            }}";

            request.AddStringBody(body, DataFormat.Json);

            // Ausführen des Requests und Warten auf die Antwort
            RestResponse response = await client.ExecuteAsync(request);

            // Anzeigen einer MessageBox, um anzuzeigen, dass der POST-Vorgang abgeschlossen ist
            MessageBox.Show(response.Content);
        }

        private async void PostCloudButton_Click(object sender, EventArgs e)
        {
            string token = await GetAccessToken();
            if (!string.IsNullOrEmpty(token))
            {
                await PostIBC(token);
            }
        }
    }
}

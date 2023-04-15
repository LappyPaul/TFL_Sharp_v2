using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFL_Sharp_v2
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> APIList = new Dictionary<string, string>();
        HttpWebRequest myHttpWebRequest;
        HttpWebResponse myHttpWebResponse;
        StreamReader myReader;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //APIList.Add("All National Rail line statuses", "https://api.tfl.gov.uk/line/mode/national-rail/status");
            APIList.Add("All London Underground line statuses", "https://api.tfl.gov.uk/line/mode/tube/status");

            cboAPI.DataSource = APIList.ToList();
            cboAPI.ValueMember = "Value";
            cboAPI.DisplayMember = "Key";

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(APIList[cboAPI.Text]);
            string returnedJsonData = callAPI();

            List<LineDetails> returnedDataToDeserialize = JsonConvert.DeserializeObject<List<LineDetails>>(returnedJsonData);

            foreach (LineDetails lineNames in returnedDataToDeserialize)
            {
                lstLines.Items.Add(lineNames.name);
            }
        }
        private string callAPI()
        {
            //myHttpWebRequest.PreAuthenticate = true;
            //myHttpWebRequest.Headers.Add("Authorization", "Bearer " + "fcde1f9299024f0d8d9f6adbe12fe4e1");
            myHttpWebRequest.Method = "Get";
            myHttpWebRequest.ContentType = "application/json";
            myHttpWebRequest.Accept = "application/json";
            myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            myReader = new StreamReader(myHttpWebResponse.GetResponseStream());
            string returnedJsonData = myReader.ReadToEnd();
            return returnedJsonData;
        }

        private void lstLines_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearDown();

            string lineToGetMoreDetails = lstLines.SelectedItem.ToString();
            lineToGetMoreDetails = lineToGetMoreDetails.Replace(" & ", "-").Replace("Line", "");

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create("https://api.tfl.gov.uk/Line/" + lineToGetMoreDetails + "/Status/");
            string returnedJsonData = callAPI();

            List<LineDetails> returnedData = JsonConvert.DeserializeObject<List<LineDetails>>(returnedJsonData);
            foreach (LineDetails lineNames in returnedData)
            {
                if (lineNames.lineStatuses[0].statusSeverity != 10)     //10 is good service
                {
                    txtStatus.Text = lineNames.lineStatuses[0].statusSeverityDescription + " " + Environment.NewLine + lineNames.lineStatuses[0].reason;
                }
                else
                {
                    txtStatus.Text = lineNames.lineStatuses[0].statusSeverityDescription;
                }
            }

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create("https://api.tfl.gov.uk/Line/" + lineToGetMoreDetails + "/StopPoints/");
            returnedJsonData = callAPI();

            List<StationData> stationData = JsonConvert.DeserializeObject<List<StationData>>(returnedJsonData);
            foreach (StationData station in stationData)
            {
                string stationName = station.commonName.Replace("Underground Station","");
                lstStations.Items.Add(stationName);
            }
        }

        private void lstStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            string stationToCheck;
            stationToCheck = lstLines.SelectedItem.ToString().Replace(" & ", "-").Replace(" ", "-").Replace("Line", "");
            //stationToCheck = stationToCheck.Replace(" & ", "-").Replace(" ", "-").Replace("Line", "");

            myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create("https://api.tfl.gov.uk/Line/" + stationToCheck + "/StopPoints");
            string returnedAllOfJson = callAPI();

            List<StationData> returnSerializedData = JsonConvert.DeserializeObject<List<StationData>>(returnedAllOfJson);
            txtNaptanID.Text = returnSerializedData[lstStations.SelectedIndex].naptanId;
            txtLongitude.Text = returnSerializedData[lstStations.SelectedIndex].lon.ToString();
            txtLatitude.Text = returnSerializedData[lstStations.SelectedIndex].lat.ToString();

            double latForMap = Convert.ToDouble(txtLatitude.Text);
            double lonForMap = Convert.ToDouble(txtLongitude.Text);

            //ClearDown();
            bool nightService = false;

            //StringBuilder queryStation = new StringBuilder();
            //queryStation.Append("http://maps.google.com/maps?q=" + latForMap + "," + lonForMap +"&z=10&amp;output=embed");
            //webBrowser1.Navigate(queryStation.ToString());

            foreach (additionalProperties additionalProperties in returnSerializedData[lstStations.SelectedIndex].additionalProperties)
            {
                //if(additionalProperties.key =="Address")
                switch (additionalProperties.key.ToUpper())
                {
                    case "ADDRESS":
                        string stationToFormat = additionalProperties.value;
                        stationToFormat = stationToFormat.Replace(",", Environment.NewLine).Replace("LONDON", "London");
                        txtStationAddress.Text = stationToFormat;
                        break;

                    case "NIGHT":
                        if (additionalProperties.value.ToUpper() == "YES")
                        {
                            nightService = true;
                        }
                        else
                            nightService = false;
                        break;

                    case "ZONE":
                        string zoneCleanUp = additionalProperties.value;
                        zoneCleanUp = zoneCleanUp.Replace("/", " + ").Replace("+", " + ");
                        txtZone.Text = zoneCleanUp;
                        break;

                }

                if (nightService == false)
                {
                    optNightServiceNo.Checked = true;
                    optNightServiceYes.Checked = false;
                }
                else
                {
                    optNightServiceNo.Checked = false;
                    optNightServiceYes.Checked = true;
                }
            }
        }
        private void txtStationAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClearDown()
        {
            txtNaptanID.Text = string.Empty;
            txtLatitude.Text = string.Empty;
            txtLongitude.Text = string.Empty;
            txtStationAddress.Text = string.Empty;
            optNightServiceNo.Checked = false;
            optNightServiceYes.Checked = false;
            txtZone.Text = string.Empty;
            lstStations.Items.Clear();
        }

        private void txtZone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
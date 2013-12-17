using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using Google.Api.Maps.Service.Geocoding;
using Google.Api.Maps.Service;
using Google.Api.Maps.Service.StaticMaps;

namespace Speech_Recognition
{
    public partial class frmMainWindow : Form
    {
        SpeechRecognizer sr;
        int bnaCounter = 0;
        private GeocodingResult currentSelectedLocation;
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Create a new SpeechRecognizer instance.
            sr = new SpeechRecognizer();

            // Create a simple grammar that recognizes "red", "green", or "blue".
            Choices jargon_grammar = new Choices();
            //jargon_grammar.Add(new string[] { "left", "right", "up" ,"down","galewela"});


            // Create a GrammarBuilder object and append the Choices object.
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(jargon_grammar);

            // Create the Grammar instance and load it into the speech recognizer.
            Grammar g = new Grammar(gb);
            //sr.LoadGrammar(g);
            Console.WriteLine("==================================");
            // Register a handler for the SpeechRecognized event.
            sr.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sr_SpeechRecognized);
        }

        // Create a simple handler for the SpeechRecognized event.
        void sr_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {

            MessageBox.Show(e.Result.Text );
            var request = new GeocodingRequest();
            request.Address = e.Result.Text;
            request.Sensor = "false";
            var response = GeocodingService.GetResponse(request);
            if (response.Status == ServiceResponseStatus.Ok)
            {
                currentSelectedLocation = response.Results.First();
            }
            updateMap();
            //================
            //var result = (GeocodingResult)currentSelectedLocation;
            //fullAddress.Text = result.FormattedAddress;
            //var location = result.Geometry.Location;
            //var map = new StaticMap();
            //map.Center = location.Latitude.ToString() + "," + location.Longitude.ToString();
            //txtLatitude.Text = location.Latitude.ToString();
            //txtLongitude.Text = location.Longitude.ToString();
            //map.Zoom =
            //(zoomLevels.SelectedItem == null) ? "10" : zoomLevels.Text.ToString();
            //map.Markers = map.Center;
            //map.Size = "1000" + "x" + "485";
            //map.MapType =
            //(mapTypeCombo.SelectedItem == null) ? "roadmap" : mapTypeCombo.Text.ToString();
            //map.Sensor = "false";
            //String urlToMap = map.ToUri().AbsoluteUri.ToString();
            //mapViewer.Navigate(urlToMap);

        }

        private void button1btnSearch_Click(object sender, EventArgs e)
        {
            var request = new GeocodingRequest();
            request.Address = txtLocation.Text;
            request.Sensor = "false";
            var response = GeocodingService.GetResponse(request);
            if (response.Status == ServiceResponseStatus.Ok)
            {
                currentSelectedLocation = response.Results.First();
            }
            updateMap();
        }

        private void updateMap()
        {
            var result = (GeocodingResult)currentSelectedLocation;
            fullAddress.Text = result.FormattedAddress;
            var location = result.Geometry.Location;
            var map = new StaticMap();
            map.Center = location.Latitude.ToString() + "," +location.Longitude.ToString();
            txtLatitude.Text = location.Latitude.ToString();            
            txtLongitude.Text = location.Longitude.ToString();
            map.Zoom =
            (zoomLevels.SelectedItem == null) ? "10" : zoomLevels.Text.ToString();
            map.Markers = map.Center;
            map.Size = "1000" + "x" + "485";
            map.MapType =
            (mapTypeCombo.SelectedItem == null) ? "roadmap" : mapTypeCombo.Text.ToString();
            map.Sensor = "false";
            String urlToMap = map.ToUri().AbsoluteUri.ToString();
            mapViewer.Navigate(urlToMap);
        }

        private void zoomLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateMap();
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            String str = txtLocation.Text;
            String[] input =str.Split(new char[' ']);
            try
            {
                if (input[input.Length - 1] == "search")
                {
                    var request = new GeocodingRequest();
                    request.Address = txtLocation.Text;
                    request.Sensor = "false";
                    var response = GeocodingService.GetResponse(request);
                    if (response.Status == ServiceResponseStatus.Ok)
                    {
                        currentSelectedLocation = response.Results.First();
                    }

                    updateMap();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception caught");
            }

        }
    }
}

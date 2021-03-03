using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;
using System.Threading;

namespace LocalWeather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string urlMoreInfo = "";
        private  void getLocation_Click(object sender, EventArgs e)
        {

                GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
                watcher.Start();
                while (watcher.Status != GeoPositionStatus.Ready && watcher.Permission != GeoPositionPermission.Denied)
                {
                    Thread.Sleep(100);
                }
                if (watcher.Permission == GeoPositionPermission.Denied)
                    MessageBox.Show("Permission Denied");
                else
                {
                    longitudeTextBox.Text = watcher.Position.Location.Longitude.ToString();
                    latitudeTextbox.Text = watcher.Position.Location.Latitude.ToString();
                }

        }


        private void btnGetDeviceLocation_MouseHover(object sender, EventArgs e)
        {
            ToolTip getDeviceInfo = new ToolTip();
            getDeviceInfo.AutoPopDelay = 5000;
            getDeviceInfo.InitialDelay = 500;
            getDeviceInfo.ReshowDelay = 150;
            getDeviceInfo.ShowAlways = true;
            getDeviceInfo.SetToolTip(btnGetDeviceLocation, "May be innacurate. Uses IP address to \nget approximate location");
        }

        private void btnCheckForecast_Click(object sender, EventArgs e)
        {
            LocationQuery lq;
            //Prefer longitude x latitude
            if (this.latitudeTextbox.TextLength * longitudeTextBox.TextLength > 0)
            {
                lq = new LocationQuery(double.Parse(latitudeTextbox.Text), double.Parse(longitudeTextBox.Text));
            }
            else if (txtBoxCityName.TextLength > 0)
                lq = new LocationQuery(txtBoxCityName.Text);
            else
                return;

            WeatherQuery wq = new WeatherQuery(lq);
            lblHigh.Text = $"High: {wq.tempHigh.ToString()} {wq.temperatureUnit}";
            lblLow.Text = $"Low: {wq.tempLow.ToString()} {wq.temperatureUnit}";
            lblUrl.Text = $"More Info";
            lblUrl.ForeColor = Color.Blue;
            urlMoreInfo = wq.webLocation.ToString();
        }

        private void lblMoreInfo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(urlMoreInfo);
        }
    }
}

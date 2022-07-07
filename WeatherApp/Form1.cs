using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace WeatherApp
{
    public partial class Form1 : Form
    {

        private string apiKey = "0fa0721f4edc3c3f7dfe6bf469e550c1";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = String.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}",textBox_city.Text,apiKey);
                Console.WriteLine(url);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                weatherIcon.ImageLocation = "https://api.openweathermap.org/img/w/" + Info.weather[0].icon + ".png";

                labelCondition_2.Text = Info.weather[0].main;
                labelDetails_2.Text = Info.weather[0].description;

                labelSunset_2.Text = Info.sys.sunset.ToString();
                labelSunrise_2.Text = Info.sys.sunrise.ToString();

                labelWindSpeed_2.Text = Info.wind.speed.ToString();

                labelPressure_2.Text = Info.main.pressure.ToString();

                labelTemp_2.Text = Info.main.temp.ToString();
            }
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

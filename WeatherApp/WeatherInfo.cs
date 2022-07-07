﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class WeatherInfo
    {

        public class coord
        {
            double lon { get; set; }
            double lat { get; set; }
        }


        public class weather
        {
            string main { get; set; }
            string description { get; set; }
            string icon { get; set; }
        }

        public class main
        {
            double temp { get; set; }
            double pressure { get; set; }
            double humidity { get; set; }
        }

        public class wind
        {
            double speed { get; set; }
        }

        public class sys
        {
            string sunrise { get; set; }
            string sunset { get; set; }
        }

        public class root
        {
            public coord coor { get; set; }
            public  List<weather> weather { get; set; }
            public main main { get; set; }
            public wind wind { get; set; }
            public sys sys { get; set; }
        }
    }
}

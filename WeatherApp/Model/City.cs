using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace WeatherApp.Model
{
    public class City
    {
        public int Verison { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string LocalizedName { get; set; }
        public Area County { get; set; }
        public Area AdministrativeArea { get; set; }
    }
}

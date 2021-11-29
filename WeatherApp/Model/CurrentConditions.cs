using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Model
{
    public class CurrentConditions
    {
        public DateTime LocalObservationdDateTime { get; set; }
        public int EpochTime { get; set; }
        public string WeatherText { get; set; }
        public int WeatherIcion { get; set; }

        public bool HasPrediction { get; set; }
        public object PredictionType { get; set; }
        public bool IsDayTime { get; set; }
        public Temperature Temperature { get; set; }
        public string MobileLink { get; set; }
        public string Link { get; set; }

    }
}

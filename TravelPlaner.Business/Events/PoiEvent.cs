
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelPlaner.Business.Interfaces;

namespace TravelPlaner.Business.Events
{
    public class PoiEvent : IPoi, IRate, ITravelItem, IDateable
    {
        public string Name { get; set; }
        public string TypeOfItem { get; private set; }
        public DateTime EventDateTime { get; set; }
        public TimeSpan Duration { get; set; }
        public string TypeOfPoi { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public TimeZoneInfo TimeZone { get; set; }
        public double Price { get; set; }
        public int PriceForPersons { get; set; }
        public string Currency { get; set; }
        /// <summary>
        /// Priorität zum Ansehen 0- Pflicht, 9-Wenn man zufällig vorbei kommt
        /// </summary>
        public int Priority { get; set; }

        public PoiEvent()
        {
            TypeOfItem = "POI";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelPlaner.Business.Interfaces;
using TravelPlaner.Business.Data;

namespace TravelPlaner.Business.Events
{
    public class LodgingEvent:IRate, ITravelItem
    {
        public string Name { get; set; }
        public string TypeOfItem { get; private set; }
        public Lodging Lodging { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Nights { get { return (int)(End.Date - Start.Date).TotalDays; } }
        public double Price { get ; set; }
        public int PriceForPersons { get ; set ; }
        public string Currency { get; set; }
    }
}
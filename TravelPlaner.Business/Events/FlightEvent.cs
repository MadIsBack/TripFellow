
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelPlaner.Business.Interfaces;
using TravelPlaner.Business.Data;


namespace TravelPlaner.Business.Events
{
    public class FlightEvent:IRate, ITravelItem
    {
        public string Name { get; set; }
        public string TypeOfItem { get; private set; }
        public string Description { get; set; }
        public Airport DepartureAirport { get; set; }
        public DateTime DepartureTime { get; set; }
        public Airport ArrivalAirport { get; set; }
        public DateTime ArrivalTime { get; set; }
        public TimeSpan FlightTime { get => ArrivalTime - DepartureTime; }
        public double Price { get; set; }
        public int PriceForPersons { get; set; }
        public string Currency { get; set; }

    }
}
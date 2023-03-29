
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelPlaner.Business.Interfaces;
using TravelPlaner.Business.Data;

namespace TravelPlaner.Business.Events
{
    public class RentalCarEvent:ITravelItem, IRate
    {
        public string Name { get; set; }
        public string TypeOfItem { get; private set; }
        public string Company { get; set; }
        public Location RentalStation { get; set; }
        public Location ReturnStation { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Days
        {
            get
            {
                var days = (End - Start).TotalDays;
                return (int) ((days - ((int)days)) > 0.01? days+1:days);
            }
        }
        public double Price { get; set; }
        public int PriceForPersons { get; set; }
        public string Currency { get; set; }

    }
}
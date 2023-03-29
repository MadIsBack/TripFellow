
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TravelPlaner.Business.Interfaces;
namespace TravelPlaner.Business.Data
{
    public class Location : IAddress
    {
        public string Name { get; set ; }
        public string TypeOfTarget { get ; set ; }
        public string Street { get ; set ; }
        public string StreetNumber { get ; set ; }
        public string AdditionalInfo { get ; set ; }
        public string ZipCode { get ; set ; }
        public string City { get ; set ; }
        public string State { get ; set ; }
        public string Country { get ; set ; }
        public double Longitude { get ; set ; }
        public double Latitude { get ; set ; }
        public TimeZoneInfo TimeZone { get; set; }
    }
}
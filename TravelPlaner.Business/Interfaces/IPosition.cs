
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelPlaner.Business.Interfaces
{
    interface IPosition
    {
        double Longitude { get; set; }
        double Latitude { get; set; }
        TimeZoneInfo TimeZone { get; set; }

    }
}
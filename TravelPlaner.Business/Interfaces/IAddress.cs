
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelPlaner.Business.Interfaces
{
    interface IAddress: IPosition
    {
        string Name { get; set; }
        string TypeOfTarget { get; set; }
        string Street { get; set; }
        string StreetNumber { get; set; }
        string AdditionalInfo { get; set; }
        string ZipCode { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Country { get; set; }
     
    }
}
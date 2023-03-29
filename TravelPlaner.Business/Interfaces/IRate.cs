
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelPlaner.Business.Interfaces
{
    interface IRate
    {
        /// <summary>
        ///  Preis pro Tag / Event
        /// </summary>
        double Price { get; set; }
        /// <summary>
        /// Für wie viele Personen gilt der Preis. 0 für pauschal
        /// </summary>
        int PriceForPersons { get; set; }
        string Currency { get; set; }
    }
}
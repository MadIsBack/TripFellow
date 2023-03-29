
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelPlaner.Business.Interfaces
{
    interface IDateable
    {
        DateTime EventDateTime { get; set; }
    }
}
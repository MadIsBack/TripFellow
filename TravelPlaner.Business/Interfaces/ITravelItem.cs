
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelPlaner.Business.Interfaces
{
    public interface ITravelItem
    {
        string Name { get; set; }
        string TypeOfItem { get; }
    }
}
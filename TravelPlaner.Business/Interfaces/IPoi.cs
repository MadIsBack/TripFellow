
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelPlaner.Business.Interfaces
{
    interface IPoi: IPosition
    {
        string Name { get; set; }
        string TypeOfPoi { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassLibrary
{
    public sealed class Vehicle
    {

        public String Model { get; set; }
        public String Brand { get; set; }
        public Decimal RentalPrice { get; set; }
        public String Color { get; set; }
        public bool isAvaliable { get; set; }
        public Vehicle()
        {

        }
    }
}

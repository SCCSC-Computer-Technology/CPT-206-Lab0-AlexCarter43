using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassLibrary
{
    public class Motorcycle : Vehicle
    {
        string EngineSize {  get; set; }
        public Motorcycle() { 
            EngineSize = string.Empty;
        }
        public Motorcycle(string EngineSize) {
            EngineSize = EngineSize.Trim();
        }
    }
}

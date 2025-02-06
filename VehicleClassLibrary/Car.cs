using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassLibrary
{
    public class Car : Vehicle
    {
        public int SeatingCapacity {  get; set; }
        public int numDoors { get; set; }
        public Car(int capcity, int doors) { 
        
            SeatingCapacity = capcity;
            numDoors = doors;
        }

        public Car() {
            SeatingCapacity = 2;
            numDoors = 2;
        }
        //methods do stuff

        //
        public override string ToString()
        {
            return Model.ToString() + " " + Brand.ToString()+ "  Price: "+ RentalPrice;
        }
    }
}

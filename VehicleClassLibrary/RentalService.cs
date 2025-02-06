using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassLibrary
{
    public class RentalService
    {
        List<Vehicle> vehicles;
        Car newCar = new Car();
        Motorcycle newMoto = new Motorcycle();
        
        const decimal VehicleRentalCost = 100m;
        const decimal CarRentalCost = 300m;
        public RentalService() { }

        //methods
        public void RentCar()
        {
            //print out a list of cars for user to select
            vehicles.Add(newCar);
            vehicles.Add(newMoto);
            foreach (var vehicle in vehicles) 
            {
                Console.WriteLine(string.Format("{0} - {1} - {2}", vehicle.Brand, vehicle.Model, vehicle.RentalPrice));
            }
            //Which car
            Console.WriteLine("which car?");
            string selection = Console.ReadLine();
            Vehicle selected = vehicles.Find(x => x.Brand == selection);
           
            if (selected.isAvaliable)
            {
                selected.isAvaliable = false;
                //perform rental; calculate price for days 
            }
            else
            {
                Console.WriteLine("car is not available");
            }
        }
        public void AddCarToInventory()
        {

        }
        public void RemoveCarFromInventory()
        {

        }

    }
}

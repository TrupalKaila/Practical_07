using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_07
{
    //Created a abstract class and in that abstract method
    // The principle states that objects of a base class should be replaceable with objects of its subclasses without affecting the correctness of the program.
    // Here, 'Vehicle' is the base class, and any subclass (ElectricVehicle, PetrolVehicle) can be used in place of 'Vehicle' without breaking the logic.
    public abstract class Vehicle
    {
        public abstract void StartEngine();
    }
    public class ElectricVehicle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Starting Engine using Electric Battery.");
        }
    }
    public class PetrolVehicle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Starting Engine using Petrol.");
        }
    }
}

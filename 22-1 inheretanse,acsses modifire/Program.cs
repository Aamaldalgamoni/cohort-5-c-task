using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _22_1_inheretanse_acsses_modifire
{

    //sealed
    class Vehicle
    {
        public string Brand;
        public string Model;


        public void Start()
        {
            Console.WriteLine("Vehicle is starting");
            
        }

    }

        class car:Vehicle
        {
            public int NumberOfDoor;
            public void print()
            {
                Console.WriteLine($"the car:{Brand} ,the model:{Model}the Numberofdoor:{NumberOfDoor}");

            }
        }



    

    internal class Program
    {
        static void Main(string[] args)
        {
            car mycar = new car();
            mycar.Brand = "BMW";
            mycar.Model = "aaa";
            mycar.Start();
            mycar.print();
        }
    }
}

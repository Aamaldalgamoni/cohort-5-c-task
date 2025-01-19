using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_5_c__task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string a;
            a = Console.ReadLine();
            Console.WriteLine(a);


            double b = 1235.315;
            string c = "hello";
            char d = 'Z';
            bool e = true;
            int f = 100;
            const int g = 5;

            
            string[] cars = {  "BMW", "Ford", "Mazda" };  //to print all values in array we need to use for loop
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
                Console.WriteLine(cars.Length);
            }

            string FirstName;
            string LastName;
            string YearOfBirth;
             FirstName=Console.ReadLine();
             LastName = Console.ReadLine();
            YearOfBirth =Console.ReadLine();

            Console.WriteLine(FirstName +"  "+LastName+"  " +YearOfBirth);


            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }


        }
    }
}

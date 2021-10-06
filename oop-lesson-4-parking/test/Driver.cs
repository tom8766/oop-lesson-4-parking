using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_lesson_4_parking.models;

namespace oop_lesson_4_parking.test
{
   public class Driver
    {
        public Driver()
        {
            Console.WriteLine("I am the code driver");
        }

        public void CreateObjects()
        {
            CarPark carpark = new CarPark();

            carpark.listofcustomers.Add(new Customer("a",2)) ;
            carpark.listofcustomers.Add(new Customer("b",3));
            carpark.listofcustomers.Add(new Customer("c",4));
            carpark.listofcustomers.Add(new Customer("d,",5));
            carpark.listofcustomers.Add(new Customer("e",6));
            carpark.listofcustomers.Add(new Customer("f",7));

            carpark.CalculateCharges();

            Customer customer = new Customer("g",8);
            CarParkCharge carcharge = new CarParkCharge();

            // Call ToString methods

            Console.WriteLine(carpark.ToString());
            Console.WriteLine(customer.ToString());
            Console.WriteLine(carcharge.ToString());
        }
    }
}

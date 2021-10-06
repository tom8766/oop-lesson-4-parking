using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.models
{
   public class CarPark
    {
        public List<Customer> listofcustomers = new List<Customer>();
        public CarParkCharge carParkCharge = new CarParkCharge();
        public CarPark()
        {
            Console.WriteLine("I am the carpark");
        }


        public override string ToString()
        {
            return " I am the CarPark()";
        }

        public void CalculateCharges()
        {
            foreach(Customer customer in listofcustomers)
            {
                int calculatedCharge = carParkCharge.CalculateCharges(customer.hoursParked);
                Console.WriteLine($"Calculating charges for customer : cost is {calculatedCharge} euro for registration");
            }
        }
    }

}

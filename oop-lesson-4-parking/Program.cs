using System;
using oop_lesson_4_parking.models;
using oop_lesson_4_parking.test;

namespace oop_lesson_4_parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Park  Charge Solutions");
            Driver driver = new Driver();
            driver.CreateObjects();
        }
    }
}

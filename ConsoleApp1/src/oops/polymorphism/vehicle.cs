using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.oops.polymorphism
{
    public class Vehicle
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int year { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle is stopping");
        } 
    }
}


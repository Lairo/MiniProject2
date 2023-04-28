using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject2
{
    internal class Car
    {
        public string Name;
        public string Brand;
        public int Millage;

        public void DescriptionCar()
        {
            Console.WriteLine($"This is a {Brand} {Name} and it has {Millage} miles on it.\n");

        }
    }
}

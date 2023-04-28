using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() { Brand = "WolksWagen", Name = "Polo", Millage = 10_000};

            car.DescriptionCar();
        }
    }
}

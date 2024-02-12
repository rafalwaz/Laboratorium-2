using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();

            Console.WriteLine("Bieżąca data:");
            data.WypiszDate();

            Console.WriteLine("\nData po przesunięciu w przód:");
            data.PrzesunWprzod();
            data.WypiszDate();

            Console.WriteLine("\nData po przesunięciu w tył:");
            data.PrzesunWtył();
            data.WypiszDate();
        }
    }
}

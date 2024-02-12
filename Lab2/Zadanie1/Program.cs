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
            int[] numbersArray = { 1, 2, 3, 4, 5 };
            Sumator sumator = new Sumator(numbersArray);

            Console.WriteLine("Suma: " + sumator.Suma());
            Console.WriteLine("Suma liczb podzielnych przez 2: " + sumator.SumaPodziel2());
            Console.WriteLine("Liczba elementów: " + sumator.IleElementów());
            sumator.WypiszElementy();
            sumator.WypiszElementyZakres(1, 3);
        }
    }
}

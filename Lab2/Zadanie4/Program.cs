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
            Liczba liczba = new Liczba("123");
            liczba.WypiszLiczbe();

            liczba.MnozeniaPrzezInt(3);
            liczba.WypiszLiczbe();

            liczba.Silnia(5);
        }
    }
}

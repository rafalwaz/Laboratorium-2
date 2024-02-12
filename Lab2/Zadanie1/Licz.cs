using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Licz
    {
        private int value;

        public Licz(int Value)
        {
            value = Value;
        }

        public void Dodaj(int x)
        {
            value += x;
        }

        public void Odejmij(int x)
        {
            value -= x;
        }

        public void WypiszStan()
        {
            Console.WriteLine("Wartość: " + value);
        }
    }
}

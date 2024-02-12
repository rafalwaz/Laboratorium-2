using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Sumator
    {
        private int[] Liczby;

        public Sumator(int[] numbers)
        {
            Liczby = numbers;
        }

        public int Suma()
        {
            return Liczby.Sum();
        }

        public int SumaPodziel2()
        {
            return Liczby.Where(x => x % 2 == 0).Sum();
        }

        public int IleElementow()
        {
            return Liczby.Length;
        }

        public void WypiszElementy()
        {
            foreach (var liczba in Liczby)
            {
                Console.Write(liczba + " ");
            }
            Console.WriteLine();
        }

        public void WypiszElementyZakres(int lowIndex, int highIndex)
        {
            for (int i = Math.Max(0, lowIndex); i < Math.Min(Liczby.Length, highIndex + 1); i++)
            {
                Console.Write(Liczby[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

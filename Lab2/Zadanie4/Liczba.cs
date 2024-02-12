using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Liczba
    {
        private int[] cyfry;

        public int Length { get; private set; }

        public Liczba(string stringValue)
        {
            Liczbe(stringValue);
        }

        public void NadajWartosc(string stringValue)
        {
            Liczbe(stringValue);
        }

        public void MnozeniePrzezInt(int x)
        {
            Tablice(2 * cyfry.Length);
            int carry = 0;

            for (int i = 0; i < cyfry.Length; i++)
            {
                int result = cyfry[i] * x + carry;
                cyfry[i] = result % 10;
                carry = result / 10;
            }

            while (carry > 0)
            {
                cyfry[Length++] = carry % 10;
                carry /= 10;
            }
        }

        public void WypiszLiczbe()
        {
            for (int i = cyfry.Length - 1; i >= 0; i--)
            {
                Console.Write(cyfry[i]);
            }
            Console.WriteLine();
        }

        public void Silnia(int n)
        {
            Liczba wynik = new Liczba("1");

            for (int i = 2; i <= n; i++)
            {
                wynik.MnozeniePrzezInt(i);
            }

            Console.Write("Silnia z " + n + ": ");
            wynik.WypiszLiczbe();
        }

        private void Liczbe(string stringValue)
        {
            cyfry = new int[stringValue.Length];
            for (int i = 0; i < stringValue.Length; i++)
            {
                cyfry[i] = stringValue[stringValue.Length - i - 1] - '0';
            }
        }

        private void Tablice(int newSize)
        {
            if (newSize > cyfry.Length)
            {
                int[] newArray = new int[newSize];
                Array.Copy(cyfry, newArray, cyfry.Length);
                cyfry = newArray;
            }
        }

        internal void MnozeniaPrzezInt(int v)
        {
            Tablice(2 * cyfry.Length);
            int carry = 0;

            for (int i = 0; i < cyfry.Length; i++)
            {
                int result = cyfry[i] * v + carry;
                cyfry[i] = result % 10;
                carry = result / 10;
            }

            while (carry > 0)
            {
                cyfry[Length++] = carry % 10;
                carry /= 10;
            }
        }
    }
}

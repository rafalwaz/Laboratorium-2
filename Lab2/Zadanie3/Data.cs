using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    
    internal class Data
    {
        private DateTime currentDate;

        public Data()
        {
            currentDate = DateTime.Now;
        }

        public void WypiszDate()
        {
            Console.WriteLine(currentDate.ToShortDateString());
        }

        public void PrzesunWprzod()
        {
            currentDate = currentDate.AddDays(7); 
        }

        public void PrzesunWtył()
        {
            currentDate = currentDate.AddDays(-14); 
        }
    }
}

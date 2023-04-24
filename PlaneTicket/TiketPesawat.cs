using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTicket
{
    internal class TiketPesawat
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public int Cost { get; set; }
        public string Currency { get; set; }

        public void PrintSummary()
        {
            Console.WriteLine("Origin: {0}", Origin);
            Console.WriteLine("Destination: {0}", Destination);
            Console.WriteLine("Cost: {0} ({1})", Cost, Currency);

            if (Currency == "USD")
            {
                Cost = Cost * 15000;
                Console.WriteLine("Convert to Rupiah: {0}", Cost);
            }
            else if (Currency == "IDR")
            {
                Cost = Cost / 15000;
                Console.WriteLine("Convert to Dolar: {0}", Cost);
            }
        }
    }
}

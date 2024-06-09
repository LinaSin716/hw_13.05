using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num_1
{
    public class Money
    {
        public int Ruble { get; set; }
        public int Kopeck { get; set; }
        public Money(int ruble, int kopeck) 
        {
            Ruble = ruble;
            Kopeck = kopeck;
        }
        public void PrintSum() { Console.WriteLine($"Рублей: {Ruble}\nКопеек: {Kopeck}\nТолько в копейках: {Ruble * 100 + Kopeck}"); }
        public void SetRuble(int ruble) { Ruble = ruble; }
        public void SetKopeck(int kopeck) { Kopeck = kopeck; }
    }
}

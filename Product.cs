using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num_1
{
    public class Product : Money
    {
        public string NameProduct { get; set; }
        public int Ruble { get; set; }
        public int Kopeck { get; set; }
        public Product(int Ruble, int Kopeck, string nameProduct) : base(Ruble, Kopeck)
        {
            this.Ruble = Ruble;
            this.Kopeck = Kopeck;
            NameProduct = nameProduct;
        }
        public void Lessen(int kop)
        {
            Ruble -= kop / 100;
            Kopeck -= kop % 100;
            SetRuble(Ruble);
            SetKopeck(Kopeck);
        }
        public void PrintSum()
        {
            Console.WriteLine($"\nName: {NameProduct}");
            base.PrintSum();
        }
    }
}

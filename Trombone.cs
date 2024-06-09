using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num_3
{
    public class Trombone : Instrument
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sound { get; set; }
        public string History { get; set; }
        public Trombone(string Name, string Description, string Sound, string History)
            : base(Name, Description, Sound, History) { }
        public void PrintSound()
        {
            base.PrintSound();
            Console.WriteLine(base.Sound);
        }
        public void Show()
        {
            base.Show();
            Console.WriteLine(base.Name);
        }
        public void Desc()
        {
            base.Desc();
            Console.WriteLine(base.Description);
        }
        public void PrintHistory()
        {
            base.PrintHistory();
            Console.WriteLine(base.History);
        }
    }
}

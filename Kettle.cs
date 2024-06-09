using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num_2
{
    public class Kettle : Device
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sound { get; set; }
        public Kettle(string Name, string Description, string Sound) : base(Name, Description, Sound) { }

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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num_2
{
    public class Device
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sound { get; set; }
        public Device(string Name, string Description, string Sound) 
        {
            this.Name = Name;
            this.Description = Description;
            this.Sound = Sound;
        }

        public void PrintSound()
        {
            Console.Write("Звук: ");
        }
        public void Show()
        {
            Console.Write("\nНазвание: ");
        }
        public void Desc()
        {
            Console.Write("Описание: ");
        }
    }
}

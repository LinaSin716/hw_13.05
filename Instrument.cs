using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num_3
{
    public class Instrument
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sound { get; set; }
        public string History { get; set; }
        public Instrument(string Name, string Description, string Sound, string History)
        {
            this.Name = Name;
            this.Description = Description;
            this.Sound = Sound;
            this.History = History;
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
        public void PrintHistory()
        {
            Console.Write("История создания: ");
        }
    }
}

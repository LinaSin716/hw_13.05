using hw_13._05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num_4
{
    public class President : Worker
    {
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        public President(string Name, string Patronymic, int Age, string Type)
            : base(Name, Patronymic, Age, Type) { }

        public override void Print()
        {
            Console.WriteLine($"Name: {base.Name}\nPatronymic: {base.Patronymic}\n" +
                $"Age: {base.Age}\nType: {base.Type}\n");
        }
    }
}

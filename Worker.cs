using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num_4
{
    public abstract class Worker
    {
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
        public Worker(string Name, string Patronymic, int Age, string Type) 
        { 
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.Age = Age;
            this.Type = Type;
        }
        public abstract void Print();
    }
}

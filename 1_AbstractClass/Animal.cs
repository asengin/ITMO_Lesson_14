using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractClass
{
    abstract class Animal
    {
        abstract public string Name { get; set; }
        abstract public string Type { get; }
        public Animal(string name)
        {
            Name = name;
        }
        abstract public string Say();

        public void ShowInfo()
        {
            Console.WriteLine($"Меня зовут {Name}, я {Type}, " + Say());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractClass
{
    class Dog : Animal
    {
        private string name;
        public override string Name { get => name; set => name=value; }
        public override string Type { get; }

        public Dog(string name)
            :base(name)
        {
            Type = "собака";
        }
        public override string Say()
        {
            return "ГАВ";
        }
    }
}

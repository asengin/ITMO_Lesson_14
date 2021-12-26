using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractClass
{
    class Cat : Animal
    {
        private string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public override string Type { get; }

        public Cat(string name)
            : base(name)
        {
            Type = "котик";
        }
        public override string Say()
        {
            return "МЯУ";
        }
    }
}

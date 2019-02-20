using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iliya
{
    abstract class Human
    {
        abstract public string Name { get; set; }

        private int age;

        public int Age {
            get
            {
                return this.age;
            }
        }

        public Human(string name, int age)
        {
            this.Name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Name of Human : {Name} Age : {Age}";
        }
    }
}

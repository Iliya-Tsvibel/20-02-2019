using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iliya
{
    class SpiderMan : Human, IClimb
    {
        private string name;
        public SpiderMan(string name, int age, double webLeft) : base(name, age)
        {
            this.WebLeft = webLeft;
        }

        public override string Name
        {
            get
            {
                return this.name;
            }
            set 
            {
                this.name = value;
            }
        }

        public void ActivateSuperPowers()
        {
            Climb();
        }

        public void Climb()
        {
            Console.WriteLine($"Spiderman {this.name} is bites");
        }

        public double WebLeft { get; private set; }

        public override string ToString()
        {
            return $"Spiderman {WebLeft} " + base.ToString();
        }
    }
}

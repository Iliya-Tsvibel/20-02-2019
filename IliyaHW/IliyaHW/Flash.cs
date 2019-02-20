using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iliya
{
    class Flash : Human, IFlash
    {
        public Flash(string name, int age, double volt) : base(name, age)
        {
            this.Volt = volt;
        }

        public override string Name {
            get;
            set;
        }

        public void ActivateSuperPowers()
        {
            Thunder();
        }

        public void Thunder()
        {
            Console.WriteLine($"Flash {Name} is fire and thunder");
        }

        public double Volt { get; private set; }

        public override string ToString()
        {
            return $"Flash {Volt} " + base.ToString();
        }
    }
}

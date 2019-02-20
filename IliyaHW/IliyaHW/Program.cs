using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iliya
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMan vladimirPutin = new SuperMan("Putin", 30, 220);
            SpiderMan hitler = new SpiderMan("Hitler", 20, 110);
            Flash stalin = new Flash("Stalin", 10, 99.3);

            ISuperHero[] superHeroes = new ISuperHero[3];
            superHeroes[0] = vladimirPutin;
            superHeroes[1] = hitler;
            superHeroes[2] = stalin;

            ISuperHero[] superHeroesPolitim =
            {
                vladimirPutin, hitler, stalin
            };

            ISuperHero[] superHeroesNew =
            {
                new SuperMan("Putin", 30, 220),
                new SpiderMan("Hitler", 20, 110),
                new Flash("Stalin", 10, 99.3)
            };

            foreach (ISuperHero hero in superHeroes)
            {
                ActivateHero( hero );
            }


        }

        static void ActivateHero(ISuperHero superHero)
        {
            superHero.ActivateSuperPowers();
        }

        static void IdentyHero(ISuperHero hero)
        {
            if (hero is SuperMan)
            {
                Console.WriteLine("This is superman");
            }
            else if (hero is SpiderMan)
            {
                Console.WriteLine("This is Spiderman");
            }
            else if (hero is Flash)
            {
                Console.WriteLine("This is Flash");
            }
            else
            {
                Console.WriteLine($"This : {hero.GetType()}");
            }
        }

        static void AdditionalHeroData(ISuperHero hero)
        {
            SuperMan superman = hero as SuperMan;
            if (superman != null)
            {
                Console.WriteLine(superman.Speed);
            }
            else
            {
                SpiderMan spiderMan = hero as SpiderMan;
                if (spiderMan != null)
                {
                    Console.WriteLine(spiderMan.WebLeft);
                }
                else
                {
                    Flash flash = hero as Flash;
                    if (flash != null)
                    {
                        Console.WriteLine(flash.Volt);
                    }
                    else
                    {
                        Console.WriteLine("Hero not indicated");
                    }
                }
            }
        }

        static ISuperHero CreateHero(string hero)
        {
            switch (hero)
            {
                case "Flash":
                    return new Flash("Arnold Shwarznegger", 35, 220);
                case "SuperMan":
                    return new SuperMan("Obama", 19, 899999);
                case "SpiderMan":
                    return new SpiderMan("Tramp", 18, 8.7);
                default:
                    return null;
            }
        }
    }
}

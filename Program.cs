using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash a = new Flash("gary", 23, 5);
            SpidreMan b = new SpidreMan("peter", 21, 120);
            SuperMan c = new SuperMan("clark", 28, 530);
            Console.WriteLine(a);
            Console.WriteLine(b);
            ISuperhero[] allheroes = new ISuperhero[]
            {
                 new Flash("gary", 23, 5),
                 new SpidreMan("peter", 21, 120),
                 new SuperMan("clark", 28, 530),
        };

            ActiveHero(a);
            IdentifyHero(b);
            foreach (ISuperhero  i in allheroes)
            {
                ActiveHero(i);
                Console.WriteLine(i);
            }
        }
        static void ActiveHero(ISuperhero D)
        {
            
        }
        static void IdentifyHero(ISuperhero d)
        {
            if (d is SuperMan)
            {
                Console.WriteLine("superman detected");
            }
            else if (d is SpidreMan)
            {
                Console.WriteLine("spidrman detected");
            }
            else
            {
                Console.WriteLine("Flash detected");
            }
        }
       public static void GetMoreHeroData(ISuperHero hero)
        {
            if(hero is Flash)
            {
                Flash f = hero as Flash;
                Console.WriteLine("Flash voltage:{0}\n", f.Voltage);
            }
            else if(hero is Superman)
            {
                Superman s = hero as Superman;
                Console.WriteLine("Superman speed:{0}\n", s.Speed);
            }
            else
            {
                if(hero is Spiderman)
                {
                    Spiderman sp = hero as Spiderman;
                    Console.WriteLine("Spiderman web left:{0}\n", sp.WebLeft);
                }
            }
        }
        public static ISuperHero CreateHero(string heroName)
        {
            ISuperHero result = null;
            switch (heroName)
            {
                case "Spiderman":
                    Spiderman spiderman = new Spiderman("Spiderman", 16, 10);
                    result = spiderman;
                    break;
                case "Superman":
                    Superman superman = new Superman("Superman", 30, 300_000);
                    result = superman;
                    break;
                case "Flash":
                    Flash flash = new Flash("Flash", 20, 20_000);
                    result = flash;
                    break;
            }
                
            return result;
        } 
}

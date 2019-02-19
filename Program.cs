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
        static void GetMoreHeroData(ISuperhero d)
        {
            if (d is SuperMan)
            {
                SuperMan a = d is SuperMan;
            }
            else if (d is SpidreMan)
            {
                
            }
            else
            {
                
            }


        }
}

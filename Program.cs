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
            foreach (ISuperhero in allheroes[])
            {
                ActiveHero();
            }
        }
        public static string ActiveHero(ISuperhero D)
        {

            return Console.WriteLine(D.ActiveSuperPowers); ;
        }
    }
}

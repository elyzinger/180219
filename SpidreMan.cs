using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class SpidreMan : Human,IClimbe
    {
        public int WebLeft
        {
            get;
            private set;
        }
        public override string Name { get; set; }
        public SpidreMan(string name, int age, int webLeft) : base( name, age)
        {
            this.WebLeft = webLeft;
        }
        public void ActiveSuperPowers()
        {
            Console.WriteLine("has web ");
        }
        public void Climbe()
        {
            Console.WriteLine("can climbe");
        }

        public override string ToString()
        {
            return $"webleft{WebLeft} {base.ToString()}";
        }
    }
}

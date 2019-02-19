using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class SuperMan : Human,IFly
    {
        public int Speed
        {
            get;
           private set;
        }
        public override string Name { get; set; }
        public SuperMan(string name, int age, int speed) : base(name, age)
        {
            this.Speed = speed;
        }
        public void ActiveSuperPowers()
        {
            Console.WriteLine("very strong and fest");
        }
        public void Fly()
        {
            Console.WriteLine("can fly");
        }

        public override string ToString()
        {
            return $"speed: {Speed} {base.ToString()}";
        }
    }
}

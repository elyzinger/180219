using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Flash : Human, IFlash
    {

        
        public int Voltage
        {
            get;
            private set;
        }
        public override string Name { get; set; }

        public Flash( string name, int age, int voltage) : base(name, age)
        {
            this.Voltage = voltage;
        }
        public void ActiveSuperPowers()
        {
            Console.WriteLine("can run very fast");
        }
        public void Firelightning()
        {
            Console.WriteLine("power of lightning");
        }

        public override string ToString()
        {
            Firelightning();
            ActiveSuperPowers();
            return $"voltage: {Voltage} {base.ToString()}"; 

        }
    }
    


}

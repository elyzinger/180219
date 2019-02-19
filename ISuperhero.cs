using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    interface ISuperhero
    {
        void ActiveSuperPowers();
    }
    interface IFlash : ISuperhero
    {
        void Firelightning();
    }
    interface IClimbe : ISuperhero
    {
        void Climbe();
    }
    interface IFly : ISuperhero
    {
        void Fly();
    }
}

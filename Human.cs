using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    abstract class Human
    {
        private int age;
        abstract public string Name { get; set; }
        public int Age
        {
            get
            {
                return this.age;
            }
        }
        public Human(string name, int age)
        {
            this.age = age;
            this.Name = name;
        }

        public override string ToString()
        {
            return $"name: {Name} age {age} ";
        }
    }
}

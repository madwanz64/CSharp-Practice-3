using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice_3.Models.Templates
{
    internal class Animal
    {
        protected string name;
        protected int legs = 4;
        protected bool coldBlooded = false;

        public Animal()
        {

        }

        public Animal(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Legs
        {
            get { return legs; }
            set { legs = value; }
        }

        public bool ColdBlooded
        {
            get { return coldBlooded; }
            set { coldBlooded = value;}
        }

        public override string ToString()
        {
            string toString = $"{typeof(Animal)}: {{name : {Name}, legs : {Legs}, coldBlooded : {ColdBlooded} }}";
            return toString;
        }
    }
}

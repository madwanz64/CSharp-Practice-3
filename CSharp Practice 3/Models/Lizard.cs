using CSharp_Practice_3.Models.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice_3.Models
{
    internal class Lizard : Animal
    {
        public Lizard(string name) : base(name)
        {
            this.coldBlooded = true;
        }

        public void FindMyFamily()
        {
            Console.WriteLine("Saudara ditemukan di dinding.");
        }
        public override string ToString()
        {
            string toString = $"{typeof(Lizard)}: {{name : {Name}, legs : {Legs}, coldBlooded : {ColdBlooded} }}";
            return toString;
        }
    }
}

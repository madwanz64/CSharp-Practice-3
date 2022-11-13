using CSharp_Practice_3.Models.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice_3.Models
{
    internal class Penguin : Animal
    {
        protected int eggs = 0;

        public Penguin(string name) : base(name)
        {
            this.legs = 2;
        }

        public int Eggs
        {
            get { return eggs; }
            set { eggs = value; }
        }

        public void ProtectTheEggs()
        {
            if (eggs > 0)
            {
                Console.WriteLine("Telur sedang dijaga, jumlah telur sekarang adalah {0}.", eggs);
            }
            else
            {
                Console.WriteLine("Anda sedang tidak menjaga telur apapun.");
            }

        }

        public void GoToSleep()
        {
            if (eggs > 0)
            {
                Console.WriteLine("Tidur kebablasan, telur hilang satu tinggal tersisa {0}.", eggs--);
            }
            else
            {
                Console.WriteLine("Tidur tenang, tidak ada telur yang hilang karena tidak memiliki telur. ");
            }
        }

        public override string ToString()
        {
            string toString = $"{typeof(Penguin)}: {{name : {Name}, legs : {Legs}, coldBlooded : {ColdBlooded}, eggs : {Eggs}}}";
            return toString;
        }
    }
}

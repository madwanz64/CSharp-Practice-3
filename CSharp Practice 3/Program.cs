using CSharp_Practice_3.Models;
using CSharp_Practice_3.Models.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice_3
{
    internal class Program
    {
        public static Dictionary<string, Animal> animals = new Dictionary<string, Animal>();

        static void Main(string[] args)
        {
            Console.WriteLine("Animal Object");
            Animal kelinci = new Animal("Rabbid");
            Console.WriteLine("Nama hewan tersebut adalah         : {0}", kelinci.Name);
            Console.WriteLine("Jumlah kaki hewan tersebut adalah  : {0}", kelinci.Legs);
            Console.WriteLine("Apa hewan tersebut berdarah dingin : {0}", kelinci.ColdBlooded);
            Console.WriteLine(kelinci);

            Console.WriteLine("\nLizard Object");
            Lizard kadale = new Lizard("Kadale");
            Console.WriteLine("Nama hewan tersebut adalah         : {0}", kadale.Name);
            Console.WriteLine("Jumlah kaki hewan tersebut adalah  : {0}", kadale.Legs);
            Console.WriteLine("Apa hewan tersebut berdarah dingin : {0}", kadale.ColdBlooded);
            kadale.FindMyFamily();
            Console.WriteLine(kadale);

            Console.WriteLine("\nPenguin Object");
            Penguin kowalski = new Penguin("Kowalski");
            Console.WriteLine("Nama hewan tersebut adalah         : {0}", kowalski.Name);
            Console.WriteLine("Jumlah kaki hewan tersebut adalah  : {0}", kowalski.Legs);
            Console.WriteLine("Apa hewan tersebut berdarah dingin : {0}", kowalski.ColdBlooded);
            Console.WriteLine("Jumlah telur hewan tersebut adalah : {0}", kowalski.Eggs);
            kowalski.ProtectTheEggs();
            kowalski.GoToSleep();
            Console.WriteLine(kowalski);

            animals.Add("Rabbid", kelinci);
            animals.Add("Kadale", kadale);
            animals.Add("Kowalski", kowalski);
        }
    }
}

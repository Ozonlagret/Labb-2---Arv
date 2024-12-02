using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Elephant : Animal
    {
        public string Name { get; set; } = String.Empty;

        public double TuskLength { get; set; } = default;

        public Elephant(string name, int age, double weight, string species, string sound, double tuskLength) : base(name, age, weight, species, sound)
        {
            Name = name;
            Sound = sound;
            TuskLength = tuskLength;
        }

        public void EchoLocation()
        {
            Console.WriteLine("Elefanten lyssnar med fossingarna och hittar sina polare\n\n");
        }
    }
}

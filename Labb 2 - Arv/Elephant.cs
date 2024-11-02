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

        public int Weight { get; set; } = default;

        public Elephant(int age, string name, int weight) : base(age)
        {
            Name = name;
            Sound = "*Trumpetsolo*\n";
            Weight = weight;
        }

        public void EchoLocation()
        {
            Console.WriteLine("Elefanten lyssnar med fossingarna och hittar sina polare\n\n");
        }
    }
}

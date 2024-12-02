using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Bird : Animal
    {
        public string Name { get; set; } = String.Empty;

        public string FeatherColor { get; set; } = String.Empty;

        public Bird(string name, int age, double weight, string species, string sound, string featherColor) : base(name, age, weight, species, sound)
        {
            Sound = sound;
            Name = name;
            FeatherColor = featherColor;
        }

        public void StealFood()
        {
            Console.WriteLine("*Svischar ner och norpar åt sig någons churro*\n\n");
        }
    }
}

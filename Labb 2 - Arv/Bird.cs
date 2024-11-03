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

        public string FeatherColors { get; set; } = String.Empty;

        public Bird(int age, string name) : base(age)
        {
            Name = name;
            Sound = "ÄR DET DÄR GRATISMAT JAG SPANAR!?!?\n";
        }

        public void StealFood()
        {
            Console.WriteLine("*Svischar ner och norpar åt sig en hel churro*\n\n");
        }
    }
}

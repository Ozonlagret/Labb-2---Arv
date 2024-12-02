using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    public class Beaver : Rodent
    {
        public bool CanSwim { get; set; } = true;
        public string FurColor { get; set; } = String.Empty;

        public Beaver(string name, int age, double weight, string species, string sound, double bottomIncisors) : base(name, age, weight, species, sound, bottomIncisors)
        {
            Sound = sound;
            FurColor = "brun";
        }

        public void BuildDam()
        {
            Console.WriteLine("\"Vi får gå någon annanstans, bävrarna har översvämmat stället\" \n\n");
        }
    }
}

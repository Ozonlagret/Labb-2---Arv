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

        public Beaver(string name, int age) : base(age, name)
        {
            Sound = "*Motorsågsljud*\n";
        }

        public void BuildDam()
        {
            Console.WriteLine("\"Vi får gå någon annanstans, bävrarna har översvämmat stället\" \n\n");
        }
    }
}

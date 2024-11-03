using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    public class Beaver : Rodent
    {
        public bool CanSwim { get; set; } = default;

        public Beaver(string name, int age) : base(age, name)
        {
            CanSwim = true;
            Sound = "BRRRRRRRRRRRRRRRRRRRRRRRRRRRR\n";
        }

        public void BuildDam()
        {
            Console.WriteLine("\"Men vafan bävrarna har ju översvämmat stället\"" +
                "\n - En ledsen vandrare \n\n");
        }
    }
}

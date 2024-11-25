using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Rat : Rodent
    {
        public bool HasFriends { get; set; } = default;

        public Rat(bool friends, string name, int age) : base(age, name)
        {
            HasFriends = friends;
            Sound = "Jag tror soppan behöver persilja\n";
        }

        public void SpreadPlague()
        {
            Console.WriteLine("En dödlig miasma seglar långsamt genom staden");
        }
    }
}

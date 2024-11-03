using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2___Arv
{
    internal class Rat : Rodent
    {
        public string HasFriends { get; set; }

        public Rat(string friends, string name, int age) : base(age, name)
        {
            HasFriends = friends;
            Sound = "Matlagning är min passion\n";
        }

        public void SpreadPlague()
        {
            Console.WriteLine("En dödlig miasma seglar långsamt genom staden");
        }
    }
}

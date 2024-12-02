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

        public Rat(string name, int age, double weight, string species, string sound, bool friends, double bottomIncisors) : base(name, age, weight, species, sound, bottomIncisors)
        {
            HasFriends = friends;
            Sound = sound;
        }

        public void SpreadPlague()
        {
            Console.WriteLine("En dödlig miasma seglar långsamt genom staden");
        }
    }
}

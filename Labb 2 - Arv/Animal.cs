using System.Net.Cache;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Labb_2___Arv
{
    public class Animal
    {
        public string Domain { get; set; } = "Okänt";
        public string Kingdom { get; set; } = "Okänt";
        public string Phylum { get; set; } = "Okänt";
        public string Class_ { get; set; } = "Okänt";
        public string Order { get; set; } = "Okänt";
        public string Family { get; set; } = "Okänt";
        public string Species { get; set; } = "Okänt";

        public int Age { get; set; } = 0;
        public string Sound { get; set; } = "Okänt";
        public string Name { get; set; } = "Okänt";
        public double Weight { get; set; } = default;

        public Animal(string name, int age, double weight, string species, string sound)
        {
            Age = age;
            Sound = sound;
            Name = name;
            Weight = weight;
        }

        public void Taxonomy(string animal)
        {
            Console.WriteLine("Domain: " + Domain + "\nKingdom: " + Kingdom + "\nPhylum: "
                + Phylum + "\nClass: " + Class_ + "\nFamily: " + Order + "\nGenus: " + Family +
                "\nSpecies: " + Species);
        }

        public void IsAMammal(string animalType)
        {
            if (animalType == Phylum)
            {
                Console.WriteLine("Det är ett däggdjur");
            }
            else 
            {
                Console.WriteLine("Det är något annat än ett däggdjur");
            }
        }

        public static void MakeSound(string sound)
        {
            Console.WriteLine(sound);
        }
    }
}

using System.Net.Cache;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Labb_2___Arv
{
    public class Animal
    {
        public string Domain { get; set; } = "Unknown";
        public string Kingdom { get; set; } = "Unknown";
        public string Phylum { get; set; } = "Unknown";
        public string Class_ { get; set; } = "Unknown";
        public string Order { get; set; } = "Unknown";
        public string Family { get; set; } = "Unknown";
        public string Species { get; set; } = "Unknown";

        public int Age { get; set; } = 0;
        public string Sound { get; set; }

        public Animal(int age)
        {
            Age = age;
            Sound = String.Empty;
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

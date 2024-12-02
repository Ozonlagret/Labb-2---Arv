namespace Labb_2___Arv
{
    public class Rodent : Animal
    {
        public string Name { get; set; } = String.Empty;

        public double BottomIncisorsLength { get; set; }

        public Rodent(string name, int age, double weight, string species, string sound, double bottomIncisors) :base(name, age, weight, species, sound)
        {
            Name = name;
            Sound = sound;
            BottomIncisorsLength = bottomIncisors;
        }

        public void Chew()
        {
            Console.WriteLine("\"Du Britt-Marie det är hål i väggen här borta\"\n\n");
        }
    }
}

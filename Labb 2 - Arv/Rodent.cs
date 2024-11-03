namespace Labb_2___Arv
{
    public class Rodent : Animal
    {
        public string Name { get; set; } = String.Empty;

        public int BottomIncisorsMilli { get; set; }

        public Rodent(int age, string name) :base(age)
        {
            Name = name;
            Sound = "Squeak\n";
        }

        public void Chew()
        {
            Console.WriteLine("\"Du Britt-Marie det är hål i väggen här borta\"\n\n");
        }
    }
}

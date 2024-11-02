using System.Runtime.CompilerServices;

namespace Labb_2___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var beaver = new Beaver("Harald", 3);

            Console.WriteLine("The beaver goes: " + beaver.Sound);

            beaver.BuildDam();

            var rodent = new Rodent(5, default);

            Console.WriteLine("The rodent goes: " + rodent.Sound);

            rodent.Chew();

            var elephant = new Elephant(44, "Harald", 3);

            Console.WriteLine("The elephant goes: " + elephant.Sound);

            elephant.EchoLocation();

            var bird = new Bird(86, "Harald");

            Console.WriteLine("The bird goes: " + bird.Sound);

            bird.StealFood();

            var rat = new Rat("Inga vänner, bara mat","Harald", 3);

            Console.WriteLine($"The rat goes: " + rat.Sound);

            rat.SpreadPlague();
            
        }
    }
}

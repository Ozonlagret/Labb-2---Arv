using System.Runtime.CompilerServices;

namespace Labb_2___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var beaver = new Beaver("Harald", 3);

            Console.WriteLine("Bävern säger: " + beaver.Sound);

            beaver.BuildDam();

            var rodent = new Rodent(5, default);

            Console.WriteLine("Gnagaren säger: " + rodent.Sound);

            rodent.Chew();

            var elephant = new Elephant(44, "Harald", 3);

            Console.WriteLine("Elefanten säger: " + elephant.Sound);

            elephant.EchoLocation();

            var bird = new Bird(86, "Harald");

            Console.WriteLine("Fågeln säger: " + bird.Sound);

            bird.StealFood();

            var rat = new Rat(true,"Harald", 3);

            Console.WriteLine($"Råttan säger: " + rat.Sound);

            rat.SpreadPlague();


            Console.WriteLine("\n\n\n"); 
        }
    }
}

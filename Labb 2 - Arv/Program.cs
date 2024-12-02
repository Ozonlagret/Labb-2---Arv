using System.Runtime.CompilerServices;

namespace Labb_2___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var beaver = new Beaver("Bob", 3, 13.4, "Bäver", "*Motorsågsljud*\n", 2);

            Console.WriteLine("Bävern säger: " + beaver.Sound);

            beaver.BuildDam();

            var rodent = new Rodent("Douglas", 5, 0.5, "Order: Rodentia", "Squeak\n", 0.1);

            Console.WriteLine("Gnagaren säger: " + rodent.Sound);

            rodent.Chew();

            var elephant = new Elephant("Obelix", 44, 3900, "Elefant","*Trumpetsolo*\n", 1.5);

            Console.WriteLine("Elefanten säger: " + elephant.Sound);

            elephant.EchoLocation();

            var bird = new Bird("Harald", 86, 0.2, "Fågel", "Nämen titta, gratismat!\n", "Blå och svart");

            Console.WriteLine("Fågeln säger: " + bird.Sound);

            bird.StealFood();

            var rat = new Rat("Francis", 1, 0.5,"Råtta", "Jag tror soppan behöver persilja\n", true, 0.7);

            Console.WriteLine($"Råttan säger: " + rat.Sound);

            rat.SpreadPlague();


            Console.WriteLine("\n\n\n"); 
        }
    }
}

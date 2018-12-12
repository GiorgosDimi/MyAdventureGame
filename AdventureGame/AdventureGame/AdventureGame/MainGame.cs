using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class MainGame
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What's your characters name?");
            string name = Console.ReadLine();
            Hero myAwsomeHero = new Hero(name);
            Console.WriteLine("What's ypu characters race?");
            string race = Console.ReadLine();
            myAwsomeHero.Race = race;
            Console.WriteLine("What's ypu characters class?");
            string heroclass = Console.ReadLine();
            myAwsomeHero.Race = heroclass;

            AtributeGenerator at = new AtributeGenerator();
            myAwsomeHero=at.Generate(myAwsomeHero);

            Console.WriteLine(myAwsomeHero.ToString());
            Console.ReadKey();
        }
    }
}

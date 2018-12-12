using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    public class AtributeGenerator
    {
        Random myRandomGenerator = new Random();
        public Hero Generate(Hero myHero)
        {
            myHero.Strenght = myRandomGenerator.Next(1, 21);
            if (myHero.HeroClass.ToLower() == "warrior")
                myHero.Strenght = myHero.Strenght + 3;
            else if (myHero.HeroClass.ToLower() == "wizard")
                myHero.Strenght--;
            myHero.Wisdom = myRandomGenerator.Next(1, 21);
            myHero.Intelligence = myRandomGenerator.Next(1, 21);
            myHero.Constitution = myRandomGenerator.Next(1, 21);
            myHero.Dexterity = myRandomGenerator.Next(1, 21);
            myHero.Charisma = myRandomGenerator.Next(1, 21);
            myHero.HitPoints = (myHero.Strenght + myHero.Constitution);
            return myHero;
        }
    }
}

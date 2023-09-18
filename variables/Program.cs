using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //name and rank
            float score;
            float enemyValue;
            string realName;
            string gamerTag;
            float percentile;


            //name and rank
            score = 0f;
            realName = "Caleb Wolthers";
            gamerTag = "MediumSalsa";
            percentile = 85.453f;
            

            //Stats and Class
            float health = 100f;
            int lives = 3;
            float defense = 100f;
            float str = 75f;
            int mana = 0;
            float charisma = 50f;

            //Enemy
            //NOTE Enemy health multiplies by level
            float goblinHp = 5f;
            float goblinStr = 15f;
            float goblinScore = 100;

            float shamanHp = 20f;
            float shamanStr = 80f;
            float shamanScore = 3f;

            float dragonHp = 100f;
            float dragonStr = 300f;
            float dragonScore = 100f;



            //Game Vars
            string gameName = "NotSoFunGame";
            string nextChap = "--------------------------";
            string nextStart = "###############################";
            int manaPotion = 10;



            //Name and Rank Print

            Console.WriteLine("Welcome to: " + gameName);
            Console.WriteLine("");

            Console.WriteLine(realName + "/" + gamerTag);
            Console.WriteLine("Goal: 30 000 score");
                Console.WriteLine("Score: " + score);
                Console.WriteLine(nextChap);

            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Defense " + defense);
            Console.WriteLine("Strength: " + str);
            Console.WriteLine("Mana: " + mana);
            Console.WriteLine("Charisma: " + charisma);
            Console.WriteLine(nextStart);
            //

            Console.WriteLine(gamerTag + " begins journey");
            Console.WriteLine("");
            Console.WriteLine(gamerTag + " Encounters a lvl-3 Goblin!");

            if (str > goblinHp * 3)
            {
                Console.WriteLine("Goblin was slain!");
            }
            else { Console.WriteLine(gamerTag + " has Died..."); }

            defense -= goblinStr;
            score += goblinScore;

            Console.WriteLine(nextChap);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Health: " + health + " Defense " + defense);
            Console.WriteLine(nextChap);
            Console.WriteLine("");

            Console.WriteLine(gamerTag + " Found a mana potion");
            mana += manaPotion;
            Console.WriteLine("Mana: " + mana);
            Console.WriteLine(nextChap);
            Console.WriteLine("");

            Console.WriteLine(gamerTag + " Encounters an lvl-3 Shaman");
            Console.WriteLine("Your defenses won't work against his spells!");
            if (str > shamanHp * 3)
            {
                Console.WriteLine("Shaman was slain!");
            }
            else { Console.WriteLine(gamerTag + " has Died..."); }
            health -= shamanStr;
            score *= shamanScore;

            Console.WriteLine(nextChap);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Health: " + health + " Defense " + defense);
            Console.WriteLine(nextChap);
            Console.WriteLine("");

            Console.WriteLine(gamerTag + " Encounters a friendly wizard");
            Console.WriteLine(gamerTag + " Charms wizard into healing him!");
            health = 100;
            Console.WriteLine("Health: " + health);
            Console.WriteLine(nextChap);
            Console.WriteLine("");


            Console.WriteLine(gamerTag + " Encounters a lvl-5 Dragon!");

            if (str > dragonHp * 5)
            {
                Console.WriteLine("Dragon was slain!");
            }
            else { Console.WriteLine(gamerTag + " has Died..."); }

            health = 0;
            defense = 0;
            lives--;

            Console.WriteLine(nextChap);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Health: " + health + " Defense " + defense);
            Console.WriteLine("RESPAWNING...");
            health += 100;
            Console.WriteLine(nextChap);
            Console.WriteLine("");

            Console.WriteLine("Treasure chest found!");
            Console.WriteLine("the chest contained: Chiro's Evil Holy Greatsword Of Dragon Beheading And Exterminating!");
            str += 1000;
            defense += 1000;
            Console.WriteLine(nextChap);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Health: " + health + " Defense " + defense);
            Console.WriteLine("Strength: " + str);
            Console.WriteLine(nextChap);
            Console.WriteLine("");

            Console.WriteLine(gamerTag + " Re-Encounters a lvl-5 Dragon!");

            if (str > dragonHp * 5)
            {
                Console.WriteLine("Dragon was slain!");
            }
            else { Console.WriteLine(gamerTag + " has Died..."); }

            defense -= dragonStr;
            score *= dragonScore;

            Console.WriteLine(nextChap);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Health: " + health + " Defense " + defense);

            Console.WriteLine(nextChap);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("You Win!!");

            //

            Console.WriteLine(nextStart);
            Console.WriteLine(nextChap);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Health: " + health + " Defense " + defense);
            Console.WriteLine("");

            //End 
            Console.WriteLine("Press any key to continue..");
                Console.ReadKey();
            

        
        
        
        
        
        
        
        }
    }
}

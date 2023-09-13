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

            int score;

            score = 45;


            if (score > 100)
            {
                Console.WriteLine("Score: " + score);
                Console.WriteLine("Press any key to continue..");
                Console.WriteLine("");
                Console.WriteLine("Except the power button");
                Console.ReadKey();
            }
            else {

                Console.WriteLine("GAME OVER");
                Console.WriteLine("");
                Console.WriteLine("Get a job");
                Console.ReadKey();

            }
        }
    }
}

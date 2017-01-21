using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            VirtualPet Grodd = new VirtualPet();

            Grodd.Intro();

            while (Grodd.hungerLevel > 0 && Grodd.thirstLevel > 0 && Grodd.wasteLevel < 11)
            {
                Grodd.StatusTracker();
                int userInput = -1;

                while(userInput != 1 && userInput != 2 && userInput != 3 && userInput !=  0)
                {
                    userInput = int.Parse(Console.ReadLine());
                }

                if (userInput == 1)
                {
                    Grodd.Feed();
                }
                else if (userInput == 2)
                {
                    Grodd.Water();
                }
                else if (userInput == 3)
                {
                    Grodd.Potty();
                }
                else if (userInput == 0)
                {
                    Grodd.Tude();
                }
                else
                {
                    Console.WriteLine("That was not a valid input, Try again.");
                }










            }


            Console.WriteLine("Gorilla Grodd has broken free. Watch your back!");









        }
    }
}

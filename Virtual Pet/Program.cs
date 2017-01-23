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

            Console.WriteLine("Welcome to virtual pet. You will be taking care of Gorilla Grodd. Good luck!");
            Console.WriteLine("\n");
            Console.WriteLine("If at any point Grodd's hunger,thirst or attitude levels go below 0 he may rebel");


            //While loop for updating status tracker based on user input
            while (Grodd.hungerLevel > 0 && Grodd.thirstLevel > 0 && Grodd.funLevel > 0 && Grodd.wasteLevel < 11)
            {
                Grodd.Directions();
                Grodd.StatusTracker();
                int userInput = int.Parse(Console.ReadLine());
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
                else if (userInput == 4)
                {
                    Grodd.Tude();
                }
                else if (userInput == 0)
                {
                    Grodd.Tude();
                }                
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("That was not a valid input, Try again.");
                    Console.WriteLine("\n");
                    
                }


            }

            Console.WriteLine("\n");
            Console.WriteLine("Gorilla Grodd has broken free. Watch your back!");







        }
    }
}

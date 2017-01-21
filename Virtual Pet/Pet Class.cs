using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Pet
{
    class VirtualPet
    {
        //feilds
        private string petName;
        private int attitude;
        private int appetite;
        private int hydration;
        private int skat;
        //Construstors
        public VirtualPet()
        {
            this.petName = "Grod";
            this.attitude = 5;
            this.appetite = 5;
            this.hydration = 5;
            this.wasteLevel = 5;
        }

        //properties
        public int hungerLevel
        {
            get { return this.appetite; }
            set { this.appetite = value; }
        }

        public int thirstLevel
        {
            get { return this.hydration; }
            set { this.hydration = value; }
        }

        public int wasteLevel
        {
            get { return this.skat; }
            set { this.skat = value; }
        }

        public int funLevel
        {
            get { return this.attitude;  }
            set { this.attitude = value; }
        }

        //Methods
        public void Intro()
        {
            Console.WriteLine("Welcome to virtual pet. You will be taking care of Gorilla Grodd. Good luck!");
            Console.WriteLine("\n");
            Console.WriteLine("Enter 0. to do nothing");
            Console.WriteLine("Enter 1. to feed Grodd");
            Console.WriteLine("Enter 2. to water Grodd");
            Console.WriteLine("Enter 3. to play with Grodd");
            Console.WriteLine("\n");
        }

        public void StatusTracker()
        {
            Console.WriteLine("Grodd's hunger level is " + appetite);
            Console.WriteLine("Grodd's thirst level is " + hydration);
            Console.WriteLine("Grodd's waste level is " + skat);
            Console.WriteLine("Grodd's attitude level is " + attitude);
        }

        public int Feed()
        {
          appetite += 2; wasteLevel += 1;
          return appetite;
        }

        public int Water()
        {
            hydration += 2; wasteLevel += 1;
            return hydration;
        }

        public int Potty()
        {
            wasteLevel -= 2; appetite -= 1; hydration -= 1;
            return skat;
        }

        public int Tude()
        {
            appetite -= 1; hydration -= 1; wasteLevel += 2; attitude -= 3;
            return attitude;

        }



    }//End Class Pet
}

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
        public void Directions() //Instructions for user to interact with virtual pet
        {
            Console.WriteLine("Enter 0. to do nothing // Enter 1.to feed Grodd // Enter 2. to water Grodd ");
            Console.WriteLine("Enter 3. to relieve with Grodd // Enter 4. to play with Grodd");
            Console.WriteLine("\n");
        }

        public void StatusTracker() //Displays current status of virtual pets attributes
        {
            Console.WriteLine("Grodd's hunger level is " + appetite);
            Console.WriteLine("Grodd's thirst level is " + hydration);
            Console.WriteLine("Grodd's waste level is " + skat);
            Console.WriteLine("Grodd's attitude level is " + attitude);
        }

        //Below are the methods for altering virtual pets attributes
        public int Feed()
        {
          Console.WriteLine("\n");
          Console.WriteLine("you fed Grodd");
          appetite += 2; wasteLevel += 1; hydration -= 1; attitude -= 1;
          return appetite;
        }

        public int Water()
        {
            Console.WriteLine("\n");
            Console.WriteLine("you watered Grodd");
            hydration += 2; wasteLevel += 1; attitude -= 1;
            return hydration;
        }

        public int Potty()
        {
            Console.WriteLine("\n");
            Console.WriteLine("you releived Grodd");
            wasteLevel -= 2; appetite -= 1; hydration -= 1; attitude += 1;
            return skat;
        }

        public int Tude()
        {
            Console.WriteLine("\n");
            Console.WriteLine("you played Grodd");
            appetite -= 1; hydration -= 1; wasteLevel += 2; attitude += 3;
            return attitude;
        }



    }//End Class Pet
}

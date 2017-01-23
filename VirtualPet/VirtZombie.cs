using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtZombie
    {
        private string zomName;
        private string brainFood;
        private string aggressionLevel;
        private string zomRot;
        private string zomSmell;
        private int anger;
        // Zombie properties
        public string ZombieName
        {
            get { return this.zomName; }
            set { this.zomName = value; }
        }

        public string Brainzz
        {
            get { return this.brainFood; }
            set { this.brainFood = value; }
        }
        public string Aggro
        {
            get { return this.aggressionLevel; }
            set { this.aggressionLevel = value; }
        }
        public string Rotting
        {
            get { return this.zomRot; }
            set { this.zomRot = value; }
        }
        public string Smelly
        {
            get { return this.zomSmell; }
            set { this.zomSmell = value; }
        }
        public int ZombieAnger
        {
            get { return this.anger; }
            set { this.anger = value; }
        }
        //Zombie Constructor
        public VirtZombie(string zomName)
        {
            this.zomName = zomName;
            this.brainFood = "Full";
            this.aggressionLevel = "Passive";
            this.Rotting = "Unblemished";
            this.zomSmell = "like a field of grass";
            this.anger = 0;
        }
        //Below are the Methods
        public void ProdZombie()
        {
            Console.Clear();
            this.anger++;
            Console.ForegroundColor = ConsoleColor.Red;


            if (this.anger == 1)
            {
                this.aggressionLevel = "Annoyed";
                Console.WriteLine("You prod the zombie with a random stick....It's getting annoyed");
                this.zomRot = "Its bruised and started some rotting";
            }
            else if (this.anger == 2)
            {
                this.aggressionLevel = "Very Annoyed";
                Console.WriteLine("Against your better Judgement you poke it again with the stick");
                this.zomRot = "Its arm has a hole from the stick, and it's rotting faster";
            }
            else if (this.anger == 3)
            {
                this.aggressionLevel = "Mad";
                Console.WriteLine("Wow you really must be bored if you keep this up");
                this.zomRot = "It's rotting faster, more disgusting";
            }
            else if(this.anger ==4)
            {
                this.aggressionLevel = "Almost in a complete Rage";
                Console.WriteLine("this is your conscious speaking..I wouldn't do that again if I were you");
                this.zomRot = "The rot is spreading thoughout the body, you can smell it";
                this.zomSmell = "Putrid";

            }
            else if(this.anger >= 5)
            {
                Console.WriteLine("Well you did it, you really got it mad, congrats");
                this.aggressionLevel = "Raging";
            }
           
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }//Prodding zombie end
        public void ZombieBath()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You give the zombie a sponge bath...ewww");
            System.Threading.Thread.Sleep(2000);
            this.zomSmell = "Freshly Picked flowers";
            this.aggressionLevel = "Feeling loved";
            Console.Clear();

        }//method bathe end
        public void ZombieFixing()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("using the zombie repair kit you fix up the zombie good as...new?");
            Console.WriteLine("You put the car air freshener around his neck.");
            System.Threading.Thread.Sleep(2000);
            this.zomRot = "Looks almost alive..almost";
            this.zomSmell = "New Car Smell";
            this.aggressionLevel = "A bit Happy for a zombie";
            Console.Clear();
        }//fix zombie end
        public void FeedZombie()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You find an extra brain in your closet and toss it to the zombie");
            Console.WriteLine("The zombie slowly devours it");
            this.brainFood = "Satisfied";
            this.anger = 0;
            this.aggressionLevel = "Passive";
            System.Threading.Thread.Sleep(3000);
        }//end feed zombie
        public void PlayZombie()
        {
            Random zomRand2 = new Random();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You let the zombie " + this.zomName + " out of the pen");
            int zomPlay = zomRand2.Next(5);
            if (zomPlay == 1)
            {
                Console.WriteLine(this.zomName + " runs around town, eating some people, but not too many");
                this.brainFood = "Stuffed";
                this.aggressionLevel = "Content";
                this.anger = 0;
                this.zomRot = "A bit bruised not rotting too bad";
                this.zomSmell = "like a bit bloody";
            }
            else if (zomPlay == 2)
            {
                Console.WriteLine(this.zomName + " runs around town, Local sheriff is called");
                this.brainFood = "Ok";
                this.aggressionLevel = "Little Upset";
                this.anger = 1;
                this.zomRot = "A bit bruised and shot up";
                this.zomSmell = "Gunpowder and fear";
            }
            else if(zomPlay == 3)
            {
                Console.WriteLine(this.zomName + " runs around town, infects everyone in sight..the national guard is called");
                Console.WriteLine("They all eat like kings.  They all got taken down " );
                Console.WriteLine(this.zomName + " got away unhurt");
                this.brainFood = "Completely Stuffed";
                this.aggressionLevel = "Full of joy and Brains";
                this.anger = 0;
                this.zomRot = "Pristine";
                this.zomSmell = "Pretty Good";
            }
            else
            {
                Console.WriteLine(this.zomName + " just stands there staring into nothingness");

            }
            System.Threading.Thread.Sleep(2000);
        }//end zombie play

    }
}

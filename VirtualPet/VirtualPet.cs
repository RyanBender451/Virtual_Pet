using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //vars used in pet properties
        private string petName;
        private int fullFood;
        private int energyLevel;
        private int funLevel;
        private int tickCount;

        public string TheName
        {
            get { return this.petName; }
            set { this.petName = value; }
        }

        public int Fullness
        {
            get { return this.fullFood; }
            set { this.fullFood = value; }
        }
        public int EnergyOf
        {
            get { return this.energyLevel; }
            set { this.energyLevel = value; }
        }
        public int FunPlay
        {
            get { return this.funLevel; }
            set { this.funLevel = value; }
        }
        public VirtualPet(string petName, int fullFood, int energyLevel, int funLevel)
        {
            this.petName = petName;
            this.fullFood = fullFood;
            this.energyLevel = energyLevel;
            this.funLevel = funLevel;
            this.tickCount = 0;
        }
        public void FeedPet()
        {
            //Pet menu. starting from the basic food to high quality
            //if the response isn't one of the choice it berates you and makes you wait some seconds
            if (this.fullFood >= 10)
            {
                Console.WriteLine(this.petName + " is not hungry now");
                System.Threading.Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Please Choose from the Menu Below");
                Console.WriteLine("(1) Meal Pellets with tap Water -- It tastes like sadness");
                Console.WriteLine("(2) Pet burger with purified water -- It is the Good Old American Pet Meal");
                Console.WriteLine("(3) LeFancy Meal with french bottled Water -- Fancy and French, for the upperclass pet");
                Console.Write("Your Choice in number form please: ");
                int petMeal = int.Parse(Console.ReadLine());
                if (petMeal == 3)
                {
                    this.fullFood = this.fullFood + 5;
                    this.fullFood = MinMax(this.fullFood);
                    this.funLevel = this.funLevel + 2;
                    this.funLevel = MinMax(this.funLevel);


                }
                else if (petMeal == 2)
                {
                    this.fullFood = this.fullFood + 3;
                    this.fullFood = MinMax(this.fullFood);
                }
                else if (petMeal == 1)
                {
                    this.fullFood = this.fullFood + 1;
                    this.fullFood = MinMax(this.fullFood);
                    this.funLevel = this.funLevel - 2;
                    this.funLevel = MinMax(this.funLevel);

                }
                else
                {
                    Console.WriteLine("Wow, not putting in a valid response and starving your pet...How Heartless ");
                    Console.WriteLine("I am giving you a couple of seconds to think on how horrible you are");
                    System.Threading.Thread.Sleep(4000);

                }
            }
            Console.Clear();
        }//end FeedPet

        public void RestPet()
        {
            if (this.energyLevel < 10)
            {
                Console.WriteLine("Yawn I am tired, I think it is sleep time");
                System.Threading.Thread.Sleep(2000);
                this.energyLevel = 10;
                string sleepZ = "Z";
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(sleepZ);
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    sleepZ = sleepZ + " Z";
                }
            }
            else if (this.energyLevel >= 10)
            {
                Console.WriteLine("I've got too much pent up energy to sleep");
                System.Threading.Thread.Sleep(1500);
            }
        }//end RestPet
        public void PetFun()
        {
            Random ranFun = new Random();
            int howFun = ranFun.Next(4);


            if (howFun == 1)
            {
                Console.WriteLine("Fetch was fun");

                this.energyLevel = this.energyLevel - 1;
                this.energyLevel = MinMax(this.energyLevel);

                this.funLevel = this.funLevel + 2;
                this.funLevel = MinMax(this.funLevel);

            }
            else if (howFun == 2)
            {
                Console.WriteLine("that was a great walk!");

                this.fullFood = this.fullFood - 1;
                this.fullFood = MinMax(this.fullFood);

                this.energyLevel = this.energyLevel - 2;
                this.energyLevel = MinMax(this.energyLevel);

                this.funLevel = this.funLevel + 3;
                this.funLevel = MinMax(this.funLevel);
            }
            else if (howFun == 3)
            {
                Console.WriteLine("That was a crazy trip through the jungle");
                this.fullFood = this.fullFood - 2;
                this.fullFood = MinMax(this.fullFood);

                this.energyLevel = this.energyLevel - 3;
                this.energyLevel = MinMax(this.energyLevel);

                this.funLevel = this.funLevel + 5;
                this.funLevel = MinMax(this.funLevel);
            }
            else
            {
                Console.WriteLine("The park was pretty good and relaxing");
                this.fullFood = this.fullFood - 1;
                this.fullFood = MinMax(this.fullFood);

                this.energyLevel = this.energyLevel - 1;
                this.energyLevel = MinMax(this.energyLevel);

                this.funLevel = this.funLevel + 2;
                this.funLevel = MinMax(this.funLevel);
            }
            System.Threading.Thread.Sleep(3000);
            Console.Clear();

        }//end PetFun Method
        public void AutoFeed()
        {
            this.fullFood = 6;
        }//end auto feed
        public int Tick()
        {
            int randomFlag;
            this.tickCount++;
            if (tickCount > 1)
            {
                Random tickAct = new Random();
                int petAction = tickAct.Next(4);

                if (petAction == 1)
                {
                    Console.WriteLine("Runs around the yard wildly");
                    this.funLevel = this.funLevel + 1;
                    this.funLevel = MinMax(this.funLevel);
                    this.energyLevel = this.energyLevel - 4;
                    this.energyLevel = MinMax(this.energyLevel);
                    randomFlag = 1;
                    System.Threading.Thread.Sleep(1500);
                }
                else if (petAction==2)
                {
                    if (this.energyLevel < 10)
                    {
                        Console.WriteLine("Takes a short powernap");
                        this.energyLevel = this.energyLevel + 3;
                        this.energyLevel = MinMax(this.energyLevel);
                        this.funLevel = this.funLevel - 1;
                        this.funLevel = MinMax(this.funLevel);
                        randomFlag = 1;
                        System.Threading.Thread.Sleep(1500);
                    }
                    else
                    {
                        Console.WriteLine("Does several backflips in the air");
                        this.energyLevel = this.energyLevel - 3;
                        this.energyLevel = MinMax(this.energyLevel);

                        this.fullFood = this.fullFood - 2;
                        this.fullFood = MinMax(this.fullFood);

                        randomFlag = 1;
                        System.Threading.Thread.Sleep(1500);
                    }
                }
                else if(petAction == 3)
                {
                    Console.WriteLine("Takes a treat and gulps it down...Yum Yum");
                    this.fullFood = this.fullFood + 1;
                    this.fullFood = MinMax(this.fullFood);
                    this.funLevel = this.funLevel - 1;
                    this.funLevel = MinMax(this.funLevel);
                    randomFlag = 1;
                    System.Threading.Thread.Sleep(1500);
                }
                else
                {
                    Console.WriteLine("A toilet fell from the sky and crushed your pet, do you want to use Necromancy to reanimate? Yes or No");
                    string answerMe = Console.ReadLine();
                    if (answerMe.ToUpper() == "YES")
                    {
                        randomFlag = 6;
                    }
                    else
                    {
                        randomFlag = 0;
                    }
                
                }
            }
            else
            {
                randomFlag = 1;
            }
            return randomFlag;
        }//end Tick

        //Keeps the food,energy,and fun levels between 0 to 10
        public int MinMax(int minMax)
        {
            if (minMax <= 0)
            {
                minMax = 0;
            }
            else if (minMax > 10)
            {
                minMax = 10;
            }
            return minMax;
        }//end MinMax

    }//End Pet Class

}

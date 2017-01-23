using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting the pet's name
            Console.WriteLine("Please give pet name");
            string pName = Console.ReadLine();
            int petFlag = 1;
            //the initial pet information
            VirtualPet pet1 = new VirtualPet(pName, 5, 5, 5);
            //do-while loop.  The loop is controled by a 'flag' variable, will go untill petFlag !=1
            //if user types leave petFlag = 0
            do
            {
                Console.WriteLine("Name: " + pet1.TheName);
                Console.WriteLine("How full of food is pet: " + pet1.Fullness);
                Console.WriteLine("Energy Level: " + pet1.EnergyOf);
                Console.WriteLine("Enjoyment: " + pet1.FunPlay);
                Console.WriteLine();
                if (pet1.Fullness <= 0)
                {
                    pet1.AutoFeed();
                    Console.Clear();
                    Console.WriteLine(pet1.TheName + " got too hungry and ate on his own");
                    continue;
                }
                Console.WriteLine("what do you want to do: FEED, SLEEP, PLAY, LEAVE...Necromancy?");
                string canDo = Console.ReadLine();
                if (canDo.ToUpper() == "LEAVE")
                {
                    petFlag = 0;
                }
                else
                {
                    //if else statements for feeding, sleeping, playing and necromancy
                    if (canDo.ToUpper() == "FEED")
                    {
                        Console.Clear();
                        pet1.FeedPet();
                        if (pet1.Fullness == 10)
                        {
                            Console.WriteLine(pet1.TheName + " is full, he won't eat any more");
                        }
                    }
                    else if (canDo.ToUpper() == "SLEEP")
                    {
                        Console.Clear();
                        pet1.RestPet();
                    }
                    else if (canDo.ToUpper() == "PLAY")
                    {
                        Console.Clear();
                        pet1.PetFun();
                        if (pet1.EnergyOf == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("You sure tired me out");
                            Console.WriteLine(pet1.TheName + " went to sleep on it's own");
                            pet1.RestPet();
                            
                        }
                    }
                    else if (canDo.ToUpper() == "NECROMANCY")
                    {
                        Console.WriteLine("You have dabbled in powers not meant for man, your pet will never be the same");
                        petFlag = 6;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("That is not one of the options...Reloading");
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();

                    }
                    //this if allows for the pet "automation"
                    if (petFlag == 1)
                    {
                        petFlag = pet1.Tick();

                        Console.Clear();
                        //If your pet fun level gets to low it forces you to play with the pet
                        if (pet1.FunPlay <= 1)
                        {
                            Console.WriteLine("Your Pet is bored I think it needs playtime with you");
                            Console.WriteLine("Play with your pet?");
                            string playTime = Console.ReadLine();
                            while (playTime.ToUpper() != "YES")
                            {
                                Console.WriteLine("I said play with your pet!");
                            }
                            if (playTime.ToUpper() == "YES")
                            {
                                pet1.PetFun();
                            }
                        }
                    }

                }

            } while (petFlag == 1);
            Console.Clear();
            //this is the end of the Normal Pet and if the flag is 6 then it starts the zombie pet
            if (petFlag == 6)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You have called upon the dark lord Melvin to turn your pet into a Zombie!");
                VirtZombie zombie1 = new VirtZombie(pet1.TheName);

                while (petFlag == 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Name: " + zombie1.ZombieName);
                    Console.WriteLine("What is the hunger level: " + zombie1.Brainzz);
                    Console.WriteLine("Aggression Level: " + zombie1.Aggro);
                    Console.WriteLine("How is it look: " + zombie1.Rotting);
                    Console.WriteLine("Smells like? " + zombie1.Smelly);
                    Console.WriteLine("What do you want to do to the zombie?");
                    Console.WriteLine("you can: 'Prod', 'feed', 'bathe', 'fix', 'play' or 'end'");
                    string choice = Console.ReadLine();
                    if (choice.ToUpper() == "END")
                    {
                        Console.Clear();
                        Console.WriteLine("You kill it, kill it with fire");
                        Console.WriteLine("Your Zombie Pet is now an Angel Pet who is hanging out with Elvis");
                        petFlag = 0;
                    }
                    else if (choice.ToUpper() == "PROD")
                    {
                        Console.Clear();
                        zombie1.ProdZombie();
                    }
                    else if (choice.ToUpper() == "FEED")
                    {
                        Console.Clear();
                        zombie1.FeedZombie();
                    }
                    else if (choice.ToUpper() == "BATHE")
                    {
                        Console.Clear();
                        zombie1.ZombieBath();

                    }
                    else if (choice.ToUpper() == "FIX")
                    {
                        Console.Clear();
                        zombie1.ZombieFixing();
                    }
                    else if (choice.ToUpper()== "PLAY")
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("What are you doing, thats not an opition");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                    }
                    if (zombie1.ZombieAnger >= 5)
                    {
                        Console.WriteLine("The zombie attacks you and eats you. Not the best way to end the day");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        petFlag = 5;
                    }

                }
            }
            if (petFlag == 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You find yourself in a fiery pit, Melvin standing over you laughing");
                Console.WriteLine("Now you have to spend enternity with Melvin.  So sad");
                Console.ResetColor();
            }
        }//end main
    }
}

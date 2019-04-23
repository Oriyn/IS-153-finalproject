using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Dungeoneers
{
    class MainClass
    {
        public static bool menu = true;
        public static int score = 0;
        public static string name;
        public static int proceed;
        public static int health = 20;
        public static int damage = 20;
        public static string Class;
       
        public static void Main(string[] args)
        {
            MainMenu();
        }
            public static void MainMenu ()
            {
            while (menu == true)
            {
                Console.WriteLine("Welcome brave soul to Dungeoneers!");
                Console.WriteLine("Play Game = 1");
                Console.WriteLine("Controls = 2");
                Console.WriteLine("Exit = 3");
                string game = Console.ReadLine();

                if (game.Contains("1"))
                {
                    menu = false;
                    Console.Clear();
                    GameStart();
                }
                else if (game.Contains("2"))
                {
                    Console.Clear();
                    Console.WriteLine("Type in your answers as you see fit");
                    Console.WriteLine("If there is no instructions press enter.:");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (game.Contains("3"))
                {
                    Environment.Exit(0);
                }
                else
                {
                Console.WriteLine("i don't understand");
                Console.ReadLine();
                Console.Clear();
                }
            }
        }
            public static void GameStart()
            {
                Console.WriteLine("What is your name Taveler?: ");
                name = Console.ReadLine();
                Console.WriteLine("Choose a class " + name);
                Console.WriteLine("Cleric, Paladin, Wizard, Bard, Warrior, Thief: ");
                Class = Console.ReadLine();
                Console.WriteLine("Well then " + name + " the " + Class + " Which dungeon do you choose to enter? 1, 2, or 3");
                string answer = Console.ReadLine();

                int dungeon = int.Parse(answer);
            //first check to make sure number is integer

                if (dungeon == 1)
                    Dungeon1();
                else if (dungeon == 2)
                    Dungeon2();
                else
                    Dungeon3();

                Console.ReadLine();

            }
        

        public static void Dungeon1()
        {

            Console.WriteLine("You have chosen dungeon 1");
            Console.WriteLine("As you travel through the narrow corridor you come to a T shape and have the option of " +
                              "going left or right which do you choose?: ");

            DirectionDecide();

            if (proceed == 3)
            {
                Console.WriteLine("You run into a wall");
                DirectionDecide();
            }
            else if (proceed == 1)
            {
                Console.WriteLine("As you move forward you find a chest down a small coridoor. ");
                Console.WriteLine("Do you choose to pursue the chest?: ");
                string getChest = Console.ReadLine();
                if (getChest.Contains("yes"))
                {
                    Console.WriteLine("The chest you so bravely opened contained a swarm of killer bees that sting the life out of you.");
                    Death();
                }
                else if (getChest.Contains("no"))
                {
                    Console.WriteLine("Well then you will never know what could have been in that chest");
                    score += 10;
                }

            }
            else if (proceed == 2)
            {
                Console.WriteLine("you see a light off in the distance");
                Console.WriteLine("as you get closer you notice a green liquid in a green vial");
                Console.WriteLine("the vial look quite delicious, do you choose to drink it?: ");
                string drink = Console.ReadLine();

                if (drink.Contains("yes"))
                {
                    Console.WriteLine("You feel your body pulse with energy gaining 10 points !!");
                    score += 10;
                }
                else if (drink.Contains("no"))
                {
                    Console.WriteLine("Good choice it could be poison set by a thief out to loot other adventurers");
                }
            }
            else
            {
                Console.WriteLine("You died");
            }

            Console.WriteLine("As you move on down a long hallway");
            Console.WriteLine("It seems to never end");
            Console.ReadLine();
            Console.WriteLine("but lo and behold you are faced with 2 doors, one marked Left Door and the other Right Door");
            Console.WriteLine("which door do you choose " + name + " the " + Class + "?: ");


            bool chooseDoor = true;
            while (chooseDoor == true)
            {
                string doorchoice = Console.ReadLine();

                if (doorchoice.Contains("left"))
                {
                    Console.WriteLine("Oh no, behind this door you run into a Demon prepare to fight adventurer! ");
                    Console.ReadLine();
                    Console.WriteLine("Quick Roll for damage !");
                    string roll = Console.ReadLine();
                    int randomnumber(int min, int max)
                    {
                        Random rnum = new Random();
                        return rnum.Next(min, max);
                    }
                    if (roll.Contains("roll"))
                    {
                        int playerRoll = randomnumber(1, 10);
                        Console.WriteLine("You Rolled " + playerRoll);

                        if (playerRoll >= 5)
                        {
                            Console.WriteLine("Good job " + name + " the " + Class + " you have slain the demon");
                            Console.WriteLine("You gain 20 points !!");
                            score += 20;
                            chooseDoor = false;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("You have been slain by the demon");
                            chooseDoor = false;
                            Death();
                        }
                    }
                }
                else if (doorchoice.Contains("right"))
                {
                    Console.WriteLine("Oh no, behind this door you run into a dragon prepare to fight adventurer! ");
                    Console.ReadLine();
                    Console.WriteLine("Quick Roll for damage !");
                    string roll = Console.ReadLine();
                    int randomnumber(int min, int max)
                    {
                        Random rnum = new Random();
                        return rnum.Next(min, max);
                    }
                    if (roll.Contains("roll"))
                    {
                        int playerRoll = randomnumber(1, 20);
                        Console.WriteLine("You Rolled " + playerRoll);

                        if (playerRoll >= 12)
                        {
                            Console.WriteLine("Good job " + name + " the " + Class + " you have slain the dragon");
                            Console.WriteLine("You gain 40 points !!");
                            score += 40;
                            chooseDoor = false;
                            Console.ReadLine();

                        }
                        else
                        {
                            Console.WriteLine("You have been slain by the dragon");
                            chooseDoor = false;
                            Death();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("i dont understand");
                }
            }

            Console.WriteLine("After slaying the monster you see a light behind it leading to the outside");
            Console.WriteLine("Good job adventurer you have bested Dungeon 1 ");
            Console.WriteLine(name +" the "+Class+ " scored " +score +" points !!!");
            Console.ReadLine();
			menu = true;
            Console.Clear();
			MainMenu();
        
    }
    public static void Dungeon2()
    {
        Console.WriteLine("You have chosen dungeon 2");
			Console.WriteLine("Looks like this dungeon is under construction");
			Console.ReadLine();
            menu = true;
			Console.Clear();
			MainMenu();
    }

    public static void Dungeon3()
    {
        Console.WriteLine("You have chosen dungeon 3");
			Console.WriteLine("Looks like this dungeon is under construction");
            Console.ReadLine();
			menu = true;
			Console.Clear();
            MainMenu();
    }



    public static void DirectionDecide()
    {

        proceed = 0;

        while (proceed == 0)
        {
            string decide1 = Console.ReadLine();

            if (decide1.Contains("left"))
            {
                Console.WriteLine("you proceed left");
                proceed += 1;
            }
            else if (decide1.Contains("right"))
            {
                Console.WriteLine("you proceed right");
                proceed += 2;
            }
            else if (decide1.Contains("straight"))
            {
                Console.WriteLine("you proceed straight");
                proceed += 3;
            }
            else

                Console.WriteLine("i don't understand");

        }
        return;
    }

    public static void Death()
    {
        health -= damage;
        if (health == 0)
        {
            Console.WriteLine("You have perished, Better luck next time adventurer");
            Console.WriteLine(name + " the " + Class + " scored " + score + " points !");
            Console.ReadLine();
            Console.Clear();
            menu = true;
            MainMenu();
        }
        else
            return;
        }
    }
}


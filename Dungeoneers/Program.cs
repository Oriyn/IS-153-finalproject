using System;

namespace Dungeoneers
{
    class MainClass
    {
        public static int proceed;
		public static int health = 20;
        public static int damage = 20;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome brave soul to Dungeoneers!");
            Console.WriteLine("What is your name Taveler?: ");
            string name = Console.ReadLine();
            Console.WriteLine("Well then " + name + " Which dungeon do you choose to enter? 1, 2, or 3");
            string answer = Console.ReadLine();
            int dungeon = int.Parse(answer);


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


            if (proceed == 1)
            {
                Console.WriteLine("As you move forward you find a chest down a small coridoor. ");
                Console.WriteLine("Do you choose to pursue the chest, yes or no?: ");
                string getChest = Console.ReadLine();
                if (getChest.Contains("yes"))
                {
                    Console.WriteLine("The chest you so bravely opened contained a swarm of killer bees that sting the life out of you.");
                    Death();
                }
                else if (getChest.Contains("no"))
                {
                    Console.WriteLine("Well then you will never know what could have been in that chest");
                }

            }
            else
            {
                Console.WriteLine("You died");
            }
                
            Console.WriteLine("Moving on down a long hallway");


        
        
        }
   
        public static void Dungeon2 ()
        {
            Console.WriteLine("You have chosen dungeon 2");
        }
    
        public static void Dungeon3 ()
        {
            Console.WriteLine("You have chosen dungeon 3");
        }



        public static void DirectionDecide()
        {
            
            proceed = 0;

            while (proceed == 0)
            {
               string decide1 = Console.ReadLine();

                if (decide1 == "left")
                {
                    Console.WriteLine("you proceed left");
                    proceed += 1;
                }
                else if (decide1 == "right")
                {
                    Console.WriteLine("you proceed right");
                    proceed += 2;
                }
                else if (decide1 == "stright")
                {
                  Console.WriteLine("you proceed stright");
                    proceed += 3;
                }
                else

                    Console.WriteLine("i don't understand");

             }
              return;
           }

        public static void Death()
        {
			damage =- health;
            if (health == 0)
            {
                Console.WriteLine("You have perished, Better luck next time adventurer");
                Console.WriteLine("You have perished, Better luck next time adventurer");
            }
            else
                return;
        }
    }
}
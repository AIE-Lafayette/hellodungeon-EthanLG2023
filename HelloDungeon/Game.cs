using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        
        public void Run()
        {
            // Player Health and damage
            float health = 100.0f;
            float damage = 1.0f;

            // Stage level
            int stageLevel = 1;

            // Player profile
            string playerName;
            string playerChoice;
            bool playerIsAlive = health > 0;
            int playerDamage = 1;
            int playerAttckSpeed = 1;
            int playerRange = 1;

            // Stage 1 Enemy Profile's
            string stage1BossEnemy = "Giant";
            string stage1EnemyLvL5 = "Cyclops";
            string stage1EnemyLvL4 = "Tree Monster";
            string stage1EnemyLvL3 = "Goblin";
            string stage1EnemyLvL2 = "Bat";
            string stage1EnemyLvL1 = "Slime";

            // Slime stats

            int slimehealth = 2;
            int slimedamage = 3;
            int slimerange = 1;
            int slimeAttackSpeed = 1;



            // Weapon Classes

            string Sword;
            string Bow;
            string Gun;

            // Sword stats

            int swordDamage = 5;
            int swordAttackSpeed = 3;
            int swordRange = 2;

            // Bow stats

            int bowDamage = 3;
            int bowAttackSpeed = 2;
            int bowRange = 6;

            // The gun stats

            int gunDamage = 10;
            int gunAttackSpeed = 1;
            int gunRange = 7;

            // Starting story line
            Console.WriteLine("You wake up in a strange place unfamiliar to you. You sit up and look around");
            Console.ReadKey(true);
            Console.WriteLine("'Where am I?' You said as you stumbble to your feet. 'Did I Die?' You ask yourself as the last thing you remember is pushing a girl out of the way of an oncomming bus.");
            Console.ReadKey(true);
            Console.WriteLine("You look around and see a town in the distance 'Maybe they can tell me where i am.' You head towards the town in hopes of gaining a sense of relief in where you are.");
            Console.ReadKey(true);
            Console.WriteLine("You arive in the Town and are greeted by a strange man");
            Console.WriteLine("Hello there traveler!");
            Console.ReadKey(true);
            Console.WriteLine("I am the Village Elder Karamm");
            Console.WriteLine("What might be your name?");

            // Player name
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();

            playerName = firstName + " " + lastName;

            // Continued story line
            Console.Clear();
            Console.WriteLine("Welcome to New London " + playerName);
            Console.ReadKey(true);
            Console.WriteLine("Enjoy the shops and rest at the inn and come see me when you can i have something to ask of you.");

            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("Thank you for coming back to see me. We need your help to defeat the " + stage1BossEnemy + " that terrorizes our village");
            Console.ReadKey(true);
            Console.WriteLine("Do you agree to help us? We promise a hefty reward if you are to prevail.");

            // Player choses to help or not

            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");

            playerChoice = Console.ReadLine();

            if (playerChoice == "1" || playerChoice == "yes") 
            {
                Console.WriteLine("Thank you " + playerName);
            }

            else if (playerChoice == "2" || playerChoice == "no") 
            {
                Console.WriteLine("How unfortunate, come back later then when you are ready.");
            }
            else
            {
                Console.WriteLine("Pick one of the choices Dumbass");
            }

            // Player chosses weapon

            Console.ReadKey(true);
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("Now before we begin please selct your weapon");
            Console.WriteLine("1.The Sword of Aragorn");
            Console.WriteLine("2.The Bow of Legolas");
            Console.WriteLine("3.A Fucking Gun");

            playerChoice = Console.ReadLine();

            if (playerChoice == "1")
            {
                playerDamage = swordDamage;
                playerAttckSpeed = swordAttackSpeed;
                playerRange = swordRange;
            }

            else if (playerChoice == "2")
            {
                playerDamage = bowDamage;
                playerAttckSpeed = bowAttackSpeed;
                playerRange = bowRange;
            }

            else if (playerChoice == "3")
            {
                playerDamage = gunDamage;
                playerAttckSpeed = gunAttackSpeed;
                playerRange = gunRange;
            }

            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("Goodluck and may the gods watch over you.");
            Console.ReadKey(true);
            Console.WriteLine("You are led into the dark forest where your jorney officially begins.");

            bool enemyAlive = true;

            if (playerIsAlive && enemyAlive)
            {
                //Perform battle logic
            }

            else
            {
                //Display results
            } 
            
        }
    }
}

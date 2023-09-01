using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {

        string DisplayMenu(string prompt, string option1, string option2, string option3)
        {
            string playerChoice = "";
            while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
            {
                //display prompt
                Console.Clear();
                Console.WriteLine(prompt);

                //display options
                Console.WriteLine("1." + option1);
                Console.WriteLine("2." + option2);

                if (option3 != "")
                {
                    Console.WriteLine("3." + option3);
                }
                //get player input
                Console.Write("> ");
                playerChoice = Console.ReadLine();

                if (playerChoice != "1" && playerChoice != "2")
                {
                    //if player input isnt one of options
                    if (playerChoice == "3" && playerChoice != "")
                    {
                        continue;
                    }
                    //error messages
                    Console.Clear();
                    Console.WriteLine("Invalid input.");
                    Console.WriteLine("Please Select a Corect choice");
                    playerChoice = "";
                }

                playerChoice = Console.ReadLine();

            }

            return playerChoice;
        }
            public void Run()
            {
             

               
                 
                // Player Health and damage
                float health = 100.0f;
                float damage = 1.0f;

                // Stage level
                int stageLevel = 1;

                // Player profile
                string playerName = "";
                string playerChoice = "";
                bool playerIsAlive = health > 0;
                int playerDamage = 1;
                int playerAttackSpeed = 1;
                int playerRange = 1;
                bool gameOver = false;

                // Stage 1 Enemy Profile's
                string stage1BossEnemy = "Giant";
                string stage1EnemyLvL5 = "Cyclops";
                string stage1EnemyLvL4 = "Tree Monster";
                string stage1EnemyLvL3 = "Goblin";
                string stage1EnemyLvL2 = "Bat";
                string stage1EnemyLvL1 = "Slime";

                // Slime stats

                int slimeHealth = 10;
                int slimeDamage = 3;
                int slimeRange = 1;
                int slimeAttackSpeed = 1;

                // Bat stats

                int batHealth = 15;
                int batDamage = 5;

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
                int gunAttackSpeed = 5;
                int gunRange = 6;

                //Game loop
                while (gameOver != true)
                {
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
                    Console.Clear();
                    Console.WriteLine("I am the Village Elder Karamm");

                    while (playerChoice != "1")
                    {
                        Console.WriteLine("What might be your name?");

                        Console.Write(">");
                        // Player name
                        string firstName = Console.ReadLine();
                        string lastName = Console.ReadLine();

                        Console.WriteLine("Is this the name you would like?");

                        Console.WriteLine("1.Yes");
                        Console.WriteLine("2.No");

                        Console.Write(">");
                        playerChoice = Console.ReadLine();

                        playerName = firstName + " " + lastName;
                    }

                    playerChoice = "";

                    // Continued story line
                    Console.Clear();
                    Console.WriteLine("Welcome to New London " + playerName);
                    Console.ReadKey(true);
                    Console.WriteLine("Enjoy the shops and rest at the inn and come see me when you can i have something to ask of you.");

                    Console.ReadKey(true);

                    while (playerChoice != "1" && playerChoice != "yes")
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for coming back to see me. We need your help to defeat the " + stage1BossEnemy + " that terrorizes our village");
                        Console.ReadKey(true);
                        Console.WriteLine("Do you agree to help us? We promise a hefty reward if you are to prevail.");

                        // Player choses to help or not

                        Console.WriteLine("1.Yes");
                        Console.WriteLine("2.No");

                        Console.Write(">");
                        playerChoice = Console.ReadLine();

                        Console.Clear();
                        if (playerChoice == "1" || playerChoice == "yes")
                        {
                            Console.WriteLine("Thank you " + playerName);
                            Console.ReadKey(true);
                        }

                        else if (playerChoice == "2" || playerChoice == "no")
                        {
                            Console.WriteLine("How unfortunate, come back later then when you are ready.");
                            Console.ReadKey(true);
                        }
                        else
                        {
                            Console.WriteLine("Pick one of the choices Dumbass");
                            Console.ReadKey(true);
                        }
                    }

                    playerChoice = "";

                    // Player chosses weapon

                    while (playerChoice != "yes")
                    {
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
                            playerAttackSpeed = swordAttackSpeed;
                            playerRange = swordRange;
                        }

                        else if (playerChoice == "2")
                        {
                            playerDamage = bowDamage;
                            playerAttackSpeed = bowAttackSpeed;
                            playerRange = bowRange;
                        }

                        else if (playerChoice == "3")
                        {
                            playerDamage = gunDamage;
                            playerAttackSpeed = gunAttackSpeed;
                            playerRange = gunRange;
                        }

                        Console.Clear();
                        Console.WriteLine("Are you sure you want this weapon");
                        Console.WriteLine("yes");
                        Console.WriteLine("no");

                        playerChoice = Console.ReadLine();
                    }

                    Console.Clear();
                    Console.WriteLine("Name:" + playerName);
                    Console.WriteLine("Health:" + health);
                    Console.WriteLine("Damage:" + playerDamage);
                    Console.WriteLine("Attack Speed:" + playerAttackSpeed);


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

                    //end of stage
                    while (playerChoice != "2")
                    {
                        //end of stage choices
                        Console.WriteLine("Congratulations " + playerName + " youve made it to the end of the first stage.");
                        Console.WriteLine("If you'd like to continue to another stage press 1.");
                        Console.WriteLine("If youd like to restart this stage press 2.");

                        if (playerChoice == "1")
                        {
                            Console.WriteLine("Goodluck Adveturer the next town from here is in the east i've heard some bad things happening.");
                        }
                        if (playerChoice == "2")
                        {
                            gameOver = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input please select a answer choice");
                        }

                    }

                }
                float a = 4f;
                float b = 5f;

                float Add(float a, float b)
                {
                    return a + b;
                }
                Console.WriteLine(Add(a, b));
            }
        }
    }


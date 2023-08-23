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
            float health = 100.0f * 2;
            float damage = 1.0f;

            // Stage level
            int stageLevel = 1;

            // Player profile
            string playerName;
            bool playerIsAlive = health > 0;
            int playerMaxStrength = 10;

            // Stage 1 Enemy Profile's
            string stage1BossEnemy = "Giant";
            string stage1EnemyLvL5 = "Cyclops";
            string stage1EnemyLvL4 = "Tree Monster";
            string stage1EnemyLvL3 = "Goblin";
            string stage1EnemyLvL2 = "Bat";
            string stage1EnemyLvL1 = "Slime";

            // Weapon stats
            float weaponStrength = 5.0f;
            float weaponDamage = 0.1f;

            // Starting story line
            Console.WriteLine("Hello there traveler!");
            Console.WriteLine("What might be your name?");

            // Player name
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();

            playerName = firstName + " " + lastName;

            // Continued story line
            Console.WriteLine("Welcome to New London " + playerName);
            Console.WriteLine("We need your help to defeat the " + stage1BossEnemy);
            Console.WriteLine("Do you agree to help us? We promise a hefty reward if you are to prevail.");
            Console.ReadLine();

            Console.WriteLine("Thank you " + playerName + ", may the luck of the gods be on your side.");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5Simulator
{
    class Event
    {
        public static Player CombatLoop(Player player, Enemy enemy)
        {
            Console.WriteLine("A {0} wants to fight", enemy.Name);
            System.Threading.Thread.Sleep(1500);
            while(player.IsAlive == true && enemy.IsAlive == true)
            {
                Console.WriteLine("Health:{1}{0}Depression:{2}{0}Items in Inventory{3}", Environment.NewLine, player.Health, player.Depression, player.Inventory.Count.ToString());
                Console.WriteLine("Chose your move{0}1.Attack{0}2.Use Item{0}3.Run Away", Environment.NewLine);
                string response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        Random random = new Random();
                        int outcome = random.Next(0, 100);
                        if (outcome <= player.Depression)
                        {
                            Console.WriteLine("Your depression made you reconsider your actions");
                        }
                        else
                        {
                            Console.WriteLine("{0} Damage Dealt", player.Damage);
                            enemy.Health = enemy.Health - player.Damage;
                            if(enemy.Health <= 0)
                            {
                                Console.WriteLine("The Enemy is Dead!");
                                enemy.IsAlive = false;
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("What Item Would you like to use?{0}1.Health{0}2.Antidepressant", Environment.NewLine);
                        string response2 = Console.ReadLine();
                        switch (response2)
                        {
                            case "1":
                                Item item = new Item("Health", 25);
                                player.UseItemSelf(item);
                                break;
                            case "2":
                                Item item2 = new Item("Antidepressant", 25);
                                player.UseItemSelf(item2);
                                break;
                            default:
                                Console.WriteLine("You did not make a valid selection");
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("You cannot run away");
                        break;
                    default:
                        Console.WriteLine("You did nothing");
                        break;
                }

                if(enemy.IsAlive == false)
                {
                    break;
                }
                Console.WriteLine("{0} Attacks you", enemy.Name);
                Random rng = new Random();
                int outcome2 = rng.Next(0, 100);
                if(outcome2 >= 75)
                {
                    Console.WriteLine("{0} Has Missed!", enemy.Name);
                }
                else
                {
                    player.Health = player.Health - enemy.BaseDamage;
                    Console.WriteLine("{0} Damage Taken", enemy.BaseDamage);
                    if (player.Health <= 0)
                    {
                        player.IsAlive = false;
                        Console.WriteLine("You have died");
                        break;
                    }
                }
               

                Console.WriteLine("The Fight has made you more depressed");
                player.Depression = player.Depression + 10;
            }

            return player;
        }

        public static Player Shop(Player player)
        {
            bool exit = false;
            while(exit == false)
            {
                Console.WriteLine("What would you like to purchase?{0}1.Health - 10 Money{0}2.Antidepressant - 10 Money{0}3.Exit", Environment.NewLine);
                string response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        Console.WriteLine("How much would you like to purchase?");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        if (player.Money >= quantity * 10)
                        {
                            player.Money = player.Money - quantity * 10;
                            Item health = new Item("Health", 25);
                            int counter = 0;
                            while (counter < quantity)
                            {
                                player.Inventory.Add(health);
                                counter++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Funds");
                        }
                        break;
                    case "2":
                        Console.WriteLine("How much would you like to purchase?");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        if (player.Money >= quantity * 10)
                        {
                            player.Money = player.Money - quantity * 10;
                            Item antidepressant = new Item("Antidepressant", 25);
                            int counter = 0;
                            while (counter < quantity)
                            {
                                player.Inventory.Add(antidepressant);
                                counter++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Funds");
                        }
                        break;
                    case "3":
                        exit = true;
                        break;
                }
            }
            

            return player;
        }
    }

}

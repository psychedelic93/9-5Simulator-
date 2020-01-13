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
                player.Health = player.Health - enemy.BaseDamage;
                Console.WriteLine("{0} Damage Taken", enemy.BaseDamage);
                if(player.Health <= 0)
                {
                    player.IsAlive = false;
                    Console.WriteLine("You have died");
                    break;
                }

                Console.WriteLine("The Fight has made you more depressed");
                player.Depression = player.Depression + 10;
            }

            return player;
        }
    }
}

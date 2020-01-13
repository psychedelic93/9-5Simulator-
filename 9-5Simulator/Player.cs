using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5Simulator
{
    class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Depression { get; set; }
        public int Salary { get; set; }
        public int Money { get; set; }
        public List<Item> Inventory { get; set; }
        public bool IsAlive { get; set; }

        public Player(string name, int health, int depression, int money)
        {
            this.Name = name;
            this.Level = 1;
            this.Damage = 25 * Level;
            this.Health = health;
            this.Depression = depression;
            this.Salary = 10;
            this.Money = money;
            this.Inventory = new List<Item>();
            this.IsAlive = true;
        }

        public void UseItemSelf(Item Item)
        {
            bool present = false;
            foreach(Item itemInv in Inventory)
            {
                if (itemInv.Name == Item.Name)
                {
                    present = true;
                    break;
                }
                else
                {
                    present = false;
                }
            }
            if(present == true)
            {
                switch (Item.Name)
                {
                    case "Health":
                        Health = Health + Item.Strength;
                        Inventory.Remove(Item);
                        break;
                    case "Antidepressant":
                        Depression = Depression - Item.Strength;
                        Inventory.Remove(Item);
                        break;
                }
            }
            else
            {
                Console.WriteLine("You do not have this item");
            }
            

        }

        public void ApplyPassiveDamage(int damage)
        {
            Health = Health - damage;
            if(Health <= 0)
            {
                IsAlive = false;
            }
        }

        public void IncreaseSalary(int increase)
        {
            Salary = Salary + increase;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5Simulator
{
    class Enemy
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int BaseDamage { get; set; }
        public List<Item> Inventory { get; set; }
        public bool IsAlive { get; set; }

        public Enemy(string name, int level, int health, int baseDamage)
        {
            this.Name = name;
            this.Level = level;
            this.Health = 100 * level;
            this.BaseDamage = 25;
            this.Inventory = new List<Item>();
            Item healing = new Item("Health", 50);
            Item antidepressant = new Item("Antidepressant", 50);
            Inventory.Add(healing);
            Inventory.Add(antidepressant);
            this.IsAlive = true;
        }
    }


}

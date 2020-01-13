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
        public int Health { get; set; }
        public int Depression { get; set; }
        public int Money { get; set; }
        public List<Item> Inventory { get; set; }

        public Player(string name, int health, int depression, int money)
        {
            this.Name = name;
            this.Health = health;
            this.Depression = depression;
            this.Money = money;
            this.Inventory = new List<Item>();
        }
    }
}

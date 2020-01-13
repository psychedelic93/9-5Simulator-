using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Alex", 100, 0, 0);
            Enemy enemy = new Enemy("Wasteman", 1, 100, 10);
            Event.CombatLoop(player, enemy);
            Console.ReadKey();
        }
    }
}

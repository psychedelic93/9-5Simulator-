﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5Simulator
{
    class Item
    {
        public string Name { get; set; }
        public int Strength { get; set; }

        public Item(string name, int strength)
        {
            this.Name = name;
            this.Strength = strength;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    //эсоунд должен бфть болше ИЛИ РАВЕН чем капасити
    public class FuelTank
    {
        private int capacity;
        private int amount;

        public FuelTank(int capacity)
        {
            this.capacity = capacity;
        }
        public void fuel(int amount)
        {
            if (this.amount + amount > capacity) { Console.WriteLine($"Топливо{capacity}"); }
            else { this.amount += amount; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Game
{
    public class Dice
    {
        private Random r;
        public Dice()
        {
            r = new Random();
        }
        public int Roll()
        {
            return r.Next(6) + 1;
        }
    }
}

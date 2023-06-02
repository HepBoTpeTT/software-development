using System;
using System.Collections.Generic;
using System.Text;

namespace ControlTask
{
    class Soccer : Sport
    {
        Random rank = new Random();
        public string sportName = "футбол";
        public Soccer(string name) : base(name)
        {
            this.name = name;
            details = "\n  Вид спорта: " + sportName + "\n  Разряд: " + Convert.ToString(Rank()) + "\n";
        }

        internal int Rank()
        {
            return rank.Next(5);
        }

    }
}

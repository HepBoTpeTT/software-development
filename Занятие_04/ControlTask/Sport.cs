using System;
using System.Collections.Generic;
using System.Text;

namespace ControlTask
{
    class Sport
    {
        string name;
        public Sport(string name)
        {
            this.name = name;
        }
        Random rank = new Random();
        public string Activity()
        {
            return "спорт";
        }
        public int Rank()
        {
            return rank.Next(3);
        }
    }
}

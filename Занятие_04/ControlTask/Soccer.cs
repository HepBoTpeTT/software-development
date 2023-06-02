using System;
using System.Collections.Generic;
using System.Text;

namespace ControlTask
{
    class Soccer : Sport
    {
        Random rank = new Random();
        static int rankInt;
        protected delegate void UpRankDelegate();
        protected static event UpRankDelegate Goal;
        public Soccer(string name) : base(name)
        {
            this.name = name;
            sportName = "футбол";
            Rank();
            MakeDetails();
            Goal += RankUp;
        }
        internal void Rank()
        {
            rankInt = rank.Next(5) + 1;
        }
        public void HitGoal()
        {
            Console.WriteLine("Забил гол!");
            Goal();
        }
        protected void RankUp()
        {
            rankInt++;
            Console.WriteLine("Разряд был увеличен на 1!");
            MakeDetails();
        }
        protected void MakeDetails()
        {
            details = "\n  Вид спорта: " + sportName + "\n  Разряд: " + rankInt + "\n";
        }

    }
}

using System;

namespace Game
{
    class Program
    {
        public delegate void BingoEvent();
        static void Main(string[] args)
        {
            BingoEvent bingo = Bingo;
            Gamer g1 = new Gamer("Василий");
            for (int i = 1; i <= 6; i++) {
                int points = g1.SeansGame();
                if (points == 6)
                {
                    bingo();
                }
                Console.WriteLine("Выпало количество очков {0} для игрока по имени {1}", points, g1.ToString());
            }
        }
        public static void Bingo()
        {
            Console.WriteLine("Бинго! Выпало 6 очков!");
        }
    }
}

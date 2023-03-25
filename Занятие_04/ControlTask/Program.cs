using System;

namespace ControlTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Soccer p1 = new Soccer("Данил");
            Console.WriteLine("Имя: {0}\n Увлечение: {1}\n Вид увлечения: {2}\n Разряд: {3}",p1.PersonName(), p1.SportName(), p1.KindOfActivity(), p1.SportRank());
        }
    }
}

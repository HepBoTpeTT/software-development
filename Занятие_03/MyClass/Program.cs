using System;

namespace MyClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2012);
            Book.SetPrice(12);
            b1.Show();
            Console.WriteLine("\n Итоговая стоимость аренды: {0} p.",b1.PriceBook(3));

            Book b2 = new Book("Толстой Л.Н.", "Война и мир","Наука и жизнь", 1234, 2013, 101, true);
            b2.TakeItem();
            b2.Show();

            Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");
            b3.Show();


            Console.WriteLine("\nЛаба2:");

            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.Show();
            mag1.IfSubs = true;
            mag1.Subs();

            Item[] itmas = new Item[4];
            itmas[0] = b1;
            itmas[1] = b2;
            itmas[2] = b3;
            itmas[3] = mag1;
            Array.Sort(itmas);

            Console.WriteLine("\nСортировка по инвентарному номеру");
            foreach (Item x in itmas)
            {
                x.Show();
            }

            //Доп. задание Тема 3
            GeometricProgression gp = new GeometricProgression(5, 10);
            gp.GetElement(5);
            gp.SumElement(10);
            ArithmeticProgression ap = new ArithmeticProgression(5, 10);
            ap.GetElement(5);
            ap.SumElement(10);
            Console.ReadKey();
        }
    }
}

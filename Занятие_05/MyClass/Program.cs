using System;

namespace MyClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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

            Console.WriteLine("Тестирование полиморфизма");
            Item it;
            it = b2;
            it.TakeItem();
            it.Return();
            it.Show();

            it = mag1;
            it.TakeItem();
            it.Return();
            it.Show(); */

            Console.WriteLine("Лаба 5:");
            Book b4 = new Book("Толстой Л.Н.", "Анна Каренина", "Знание", 1204, 2014, 103, true);
            Book b5 = new Book("Неш Т", "Программирование для профессионалов", "Вильямс", 1200, 2014, 108, true);
            Book.RetSrok += new Book.ProcessBookDelegate(Operation.MetodObrabotchik);

            b4.ReturnSrok = true;
            b5.ReturnSrok = true;

            Console.WriteLine("\nКниги возвращены в срок:");
            b4.ProcessPaperbackBooks(Operation.PrintTitle);
            b5.ProcessPaperbackBooks(Operation.PrintTitle);

            Console.ReadKey();
        }
    }
}

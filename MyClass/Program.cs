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

            /*
            //Доп задание
            Triangle t1 = new Triangle(6.7, 5, 11.2);
            t1.Perimeter();
            t1.Area();
            t1.Check();

            Triangle t2 = new Triangle(40, 11, 30);
            t2.Perimeter();
            t2.Area();
            t2.Check();

            //Вариант 4 (ДЗ):
            IntVector iv1 = new IntVector(Convert.ToInt32(Console.ReadLine())); //размерность массива задаётся из консоли
            iv1.ReadArray();
            iv1.PrintArray();
            iv1.SortArray();
            iv1.PrintArray();
            iv1.MultArray(5); //метод для умножения каждого элемента массива на скаляр
            iv1.PrintArray();
            */

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
            it.Show();

            Console.ReadKey();
        }
    }
}

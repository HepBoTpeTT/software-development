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

            Book b2 = new Book("Толстой Л.Н.", "Война и мир","Наука и жизнь", 1234, 2013);
            b2.Show();

            Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");
            b3.Show();


            //Доп. задание:
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
            iv1.MultArray(); //метод для умножения каждого элемента массива на скаляр
            iv1.PrintArray();

            Console.ReadKey();
        }
    }
}

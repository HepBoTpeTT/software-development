using System;

namespace MyClass
{
    internal class Book
    {
        private string author; // автор
        private string title; // название
        private string publisher; // издательство
        private int pages; // кол-во страниц
        private int year; // год издания
        private static double price = 9;
        public void SetBook(String author, string title, string publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        public static void SetPrice(double price)
        {
            Book.price = price;
        }
        public void Show()
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\nГод издания: {2}\n Издательство: {3}\n {4}стр.\nСтоимость аренды: {5}", author, title, year, publisher, pages, Book.price);
        }
        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
        public Book(string author, string title, string publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        public Book()
        {
        }
        static Book() //статический конструктор
        {
            price = 10;
        }
        public Book(string author, string title)
        {
            this.author = author;
            this.title = title;
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
    }
}

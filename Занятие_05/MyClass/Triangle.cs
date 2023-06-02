using System;

namespace MyClass
{
    internal class Triangle
    {
        private double a; //сторона1
        private double b; //сторона2
        private double c; //сторона3

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void SideShow()
        {
            Console.WriteLine("\nСторона 1: {0}\nСторона 2: {1}\nСторона 3: {2}", a, b, c);
        }
        public double Perimeter()
        {
            return a + b + c;
        }
        public double Area()
        {
            double p = Perimeter() / 2;
            double S = Math.Pow(p*(p - a) * (p - b) * (p - c), 0.5);
            return S;
        }
        public bool Check()
        {
            return ((a + b > c) & (c + b > a) & (c + a > b));
        }
    }
}

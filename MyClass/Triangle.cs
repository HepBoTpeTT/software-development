using System;

namespace MyClass
{
    internal class Triangle
    {
        private double a; //сторона1
        private double b; //сторона2
        private double c; //сторона3

        public Triangle()
        {
        }
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
        public void Perimeter()
        {
            Console.WriteLine("Периметр треугольника с заданными сторонами: {0}", a + b + c);
        }
        public void Area()
        {
            double p = (a + b + c) / 2;
            double S = Math.Pow(p*(p - a) * (p - b) * (p - c), 0.5);
            Console.WriteLine("Площадь треугольника с заданными сторонами: {0}", S);
        }
        public void Check()
        {
            bool check_flag  = false;
            if ((a+b<c) & (c + b < a) & (c + a < b))
            {
                check_flag = true;
            }
            Console.WriteLine("Результат проверки: {0}", check_flag);
        }
    }
}

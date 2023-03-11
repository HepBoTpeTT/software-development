using System;

namespace MyClass
{
    class GeometricProgression : IProgression
    {
        private double b;
        private double q;
        public GeometricProgression(double b, double q)
        {
            this.b = b;
            this.q = q;
        }
        public double GetElement(int k)
        {
            return b * Math.Pow(q,k-1);
        }
        public double SumElement(int k)
        {
            return b * (Math.Pow(q, k - 1) / (k - 1));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class GeometricProgression : Progression
    {
        private double b;
        private double q;
        public GeometricProgression(double b, double q)
        {
            this.b = b;
            this.q = q;
        }
        public override double GetElement(int k)
        {
            return b * Math.Pow(q,k-1);
        }
        public override double SumElement(int k)
        {
            return b * (Math.Pow(q, k - 1) / (k - 1));
        }
    }
}

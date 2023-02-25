using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class ArithmeticProgression : Progression
    {
        private double a;
        private double d;
        public ArithmeticProgression(double a, double d)
        {
            this.a = a;
            this.d = d;
        }
        public override double GetElement(int k)
        {
            return a + d * (k - 1);
        }

        public override double SumElement(int k)
        {
            return (2 * a + d * (k - 1)) / 2 * k;
        }
    }
}

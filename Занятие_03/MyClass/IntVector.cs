using System;

namespace MyClass
{
    internal class IntVector
    {
        private int[] IntArray;
        private int n;
        public int Length { 
            get { return n; }
            set { n = value; }
        }

        public IntVector(int n)
        {
            this.n = n;
            IntArray = new int[n];
        }

        public void ReadArray()
        {
            Console.WriteLine("\nЗаполните массив:");
            for (int i = 0; i < n; i++)
            {
                IntArray[i] = int.Parse(Console.ReadLine());
            }
        }

        public void PrintArray()
        {
            Console.WriteLine("\nЭлементы массива:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(IntArray[i]);
            }
        }

        public void SortArray()
        {
            Array.Sort(IntArray);
        }

        public void MultArray(int scalar)
        {
            for (int i = 0; i < n; i++)
            {
                IntArray[i] *= scalar;
            }
        }
    }
}

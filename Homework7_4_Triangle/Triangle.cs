using System;
namespace Homework7_4_Triangle
{
    public class Triangle
    {
        private int a, b, c;
        public int A
        {
            get { return a; }
        }
        public int B
        {
            get { return b; }
        }
        public int C
        {
            get { return c; }
        }

        public Triangle(int newA, int newB, int newC)
        {
            a = newA;
            b = newB;
            c = newC;
        }

        public double Perimeter()
        {
            return a + b + c;
        }

        public double Area()
        {
            double s = Perimeter() / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public void Info()
        {
            Console.WriteLine($"Perimeter = {Perimeter()}\nArea = {Area()}");
        }
    }
}


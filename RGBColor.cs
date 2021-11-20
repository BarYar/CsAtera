using System;

namespace CsAtera
{
    class Point
    {
        int height;
        int Age{get; set;}
        public Point(int heightval, int age)
        {
            height = heightval;
            Age = age;

        }

        public override string ToString()
        {
            return base.ToString() + height + Age;
        }
        static void Main(String[]args)
        {
            Point a = new Point(5, 5);
            Console.WriteLine(a.ToString());
            a.Age = 20;
            Console.WriteLine(a.ToString());
        }
    }
}

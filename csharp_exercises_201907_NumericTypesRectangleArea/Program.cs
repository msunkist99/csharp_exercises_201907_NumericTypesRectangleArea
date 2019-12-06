using System;

namespace csharp_exercises_201907_NumericTypesRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //int length;
            //int width;
            //int area;

            Console.WriteLine("enter rectangle length - ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("enter rectangle width - ");
            int width = int.Parse(Console.ReadLine());
            int area = length * width;
            Console.WriteLine("Area of the rectangle is " + area);

            //Console.WriteLine("Area of the rectangle is " + (length * width));

            Console.ReadLine();
        }
    }
}
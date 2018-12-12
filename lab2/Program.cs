using System;
using System.Collections.Generic;
using MoreLinq;

namespace lab2.by.bsu.lab2
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var circle1 = new Сircle(1, 10, 1, 1);
            var circle2 = new Сircle(2, 5, 4, 2);
            var circle3 = new Сircle(1, 7, 5, 1);

            var сircles = new List<Сircle> {circle1, circle2, circle3};

            Console.WriteLine("Is centers of the circles on the same line? " +
                              CircleUtil.ArePointsOnLine(circle1, circle2, circle3));

            var circleWithMaxPerimeter = сircles.MaxBy(circle => circle.CalculateCircumference());

            Console.WriteLine("Circle with max perimeter " + circleWithMaxPerimeter.First());

            var circleWithMinSquare = сircles.MinBy(circle => circle.CalculateSquare());

            Console.WriteLine("Circle with min square " + circleWithMinSquare.First());
        }
    }
}
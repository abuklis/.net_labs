using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq.Extensions;

namespace lab3.by.bsu.lab3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //EQUILATERAL
            var triangle1 = new Triangle(3, 3, 3);

            //SCALENE
            var triangle2 = new Triangle(3, 6, 7);
            var triangle3 = new Triangle(4, 5, 7);

            //RECTANGULAR    
            var triangle4 = new Triangle(3, 4, 5);
            var triangle8 = new Triangle(8, 6, 10);

            //ISOSCELES
            var triangle5 = new Triangle(3, 6, 6);
            var triangle6 = new Triangle(9, 6, 9);
            var triangle7 = new Triangle(3, 7, 3);

            var triangles = new List<Triangle>
                {triangle1, triangle2, triangle3, triangle4, triangle5, triangle6, triangle7, triangle8};

            var maxRectangularByPerimeter =
                triangles.Where(x => x.GetType() == TriangleType.Rectangular)
                    .MaxBy(triangle => triangle.CalculatePerimeter());

            Console.WriteLine("Rectangular triangle with max perimeter " + maxRectangularByPerimeter.First());

            var isoscelesTriangles =
                triangles.Where(x => x.GetType() == TriangleType.Isosceles)
                    .MinBy(triangle => triangle.CalculateSquare());

            Console.WriteLine("Isosceles triangle with min square " + isoscelesTriangles.First());

            var scaleneTriangles =
                triangles.Where(x => x.GetType() == TriangleType.Scalene);
        }
    }
}
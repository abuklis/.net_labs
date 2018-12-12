using System;

namespace lab3.by.bsu.lab3
{
    public class Triangle
    {
        public Triangle(int sideA, int sideB, int sideC)
        {
            if (IsValidTriangle(sideA, sideB, sideC))
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
            else
            {
                throw new ArgumentException("Wrong parameters for triangle");
            }
        }

        private int SideA { get; }

        private int SideB { get; }

        private int SideC { get; }

        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        public double CalculateSquare()
        {
            var p = CalculatePerimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public new TriangleType GetType()
        {
            if (SideA == SideB && SideB == SideC)
            {
                return TriangleType.Equilateral;
            }

            if (SideB == SideC || SideA == SideB || SideC == SideA)
            {
                return TriangleType.Isosceles;
            }

            if (CheckIfRectangular(SideA, SideB, SideC) ||
                CheckIfRectangular(SideA, SideC, SideB) ||
                CheckIfRectangular(SideC, SideB, SideA))
            {
                return TriangleType.Rectangular;
            }

            return TriangleType.Scalene;
        }

        public override string ToString()
        {
            return $"{nameof(SideA)}: {SideA}, {nameof(SideB)}: {SideB}, {nameof(SideC)}: {SideC}";
        }
        
        private bool CheckIfRectangular(int sideA, int sideB, int sideC)
        {
            return Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2);
        }

        private static bool IsValidTriangle(int sideA, int sideB, int sideC)
        {
            return sideA >= 0 || sideB >= 0 || sideA >= 0 || sideA <= sideB + sideC || sideC <= sideB + sideA ||
                   sideB <= sideA + sideC;
        }
    }
}
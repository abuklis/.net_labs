using System;

namespace lab4
{
    public class Round
    {
        public Circle Circle { get; set; }

        public void SetSize(Point point, double radius)
        {
            Circle = new Circle(point, radius);
        }

        public bool IsPointInRound(Point point)
        {
            var r = Math.Sqrt(Math.Pow(point.X, 2) + Math.Pow(point.Y, 2));

            return r <= Circle.Radius;
        }

        public override string ToString()
        {
            return "Round " + $"{nameof(Circle)}: {Circle}, {nameof(Circle)}: {Circle}";
        }
    }
}
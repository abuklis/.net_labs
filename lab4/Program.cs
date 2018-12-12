using System;

namespace lab4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var point1 = new Point(4, 5);
            var point2 = new Point(6, 8);
            
            var circle = new Circle(point2, 20);
            
            circle.ChangeRadius(10);
            
            var round = new Round();
            round.SetSize(point1, 10);
            
            //true
            Console.WriteLine(round.IsPointInRound(point2));
            
            round.Circle.ChangeRadius(4);
            
            //now false
            Console.WriteLine(round.IsPointInRound(point2));
            
        }
    }
}
using System;

namespace lab2.by.bsu.lab2
{
    public class Сircle {
        private long _id;

        private double Radius { get; }

        public double CenterX { get; }

        public double CenterY { get; }

        public Сircle(long id, double radius, int centerX, int centerY) {
            _id = id;
            Radius = radius;
            CenterX = centerX;
            CenterY = centerY;
        }

        public override string ToString() {
            return "Circle: id = " + _id +
                   ", radius = " + Radius;
        }
        
        public double CalculateCircumference() {
            return Radius * 2 * Math.PI;
        }
        
        public double CalculateSquare() {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
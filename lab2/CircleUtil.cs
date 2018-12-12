using System;

namespace lab2.by.bsu.lab2
{
    public class CircleUtil
    {
        public static bool ArePointsOnLine(Сircle сircle1, Сircle сircle2, Сircle сircle3) {
            var x1 = сircle1.CenterX;
            var y1 = сircle1.CenterY;
            var x2 = сircle2.CenterX;
            var y2 = сircle2.CenterY;
            var x3 = сircle3.CenterX;
            var y3 = сircle3.CenterY;
            return Math.Abs((x3 - x1) / (x2 - x1) - (y3 - y1) / (y2 - y1)) < 0;
        }
    }
}
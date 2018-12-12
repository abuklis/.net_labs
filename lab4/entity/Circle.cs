namespace lab4
{
    public class Circle
    {
        public Point Center { get; set; }

        public double Radius { get; set; }

        public void ChangeRadius(double newRadius)
        {
            Radius = newRadius;
        }

        //set's size
        public Circle(Point center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public override string ToString()
        {
            return "Circle " + $"{nameof(Center)}: {Center}, {nameof(Radius)}: {Radius}";
        }
    }
}
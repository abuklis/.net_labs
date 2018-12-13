using System;

namespace lab7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IFurniture furniture = new BookCabinet(10.0, 20.0, 40.0, 4, 5);

            Console.WriteLine(furniture.CalculateSquare());
            
            Console.WriteLine(furniture.CalculateVolume());
        }
    }
}
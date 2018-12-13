using System;
using System.Collections.Generic;
using lab7.Properties;

namespace lab7
{
    public class BookCabinet : AbstractCabinet
    {
        public int ShelvesAmount { get; set; }
        public int DrawersAmount { get; set; }
        public List<Book> Books;

        public BookCabinet(double width, double height, double length, int shelvesAmount, int drawersAmount) : base(width, height, length)
        {
            ShelvesAmount = shelvesAmount;
            DrawersAmount = drawersAmount;
            Books = new List<Book>();
        }

        public override void ShowEntry()
        {
            Books.ForEach(Console.WriteLine);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Books)}: {Books}, {nameof(ShelvesAmount)}: {ShelvesAmount}, {nameof(DrawersAmount)}: {DrawersAmount}";
        }
    }
}
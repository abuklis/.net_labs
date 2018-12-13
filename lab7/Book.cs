namespace lab7
{
    //dummy class just for demo usage
    public class Book
    {
        public long Id { get; set; }
        public string title { get; set; }
        public string author { get; set; }

        public Book(long id, string title, string author)
        {
            Id = id;
            this.title = title;
            this.author = author;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(title)}: {title}, {nameof(author)}: {author}";
        }
    }
}
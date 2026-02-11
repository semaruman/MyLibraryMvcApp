namespace MyLibraryMvcApp.Areas.Library.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Date {  get; set; }

        public string Genre {  get; set; }

        public override string ToString()
        {
            return $"{Author} {Title} {Date}";
        }
    }
}

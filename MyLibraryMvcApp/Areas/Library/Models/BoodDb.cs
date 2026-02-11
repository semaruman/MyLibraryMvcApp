using System.Text.Json;
using static System.Reflection.Metadata.BlobBuilder;

namespace MyLibraryMvcApp.Areas.Library.Models
{
    public class BoodDb
    {
        private readonly string filepath = @"Aseas/Library/Data/book_db.json";

        public void AddBook(Book book)
        {
            List<Book> books = new List<Book>();

            if (File.Exists(filepath))
            {
                string json = File.ReadAllText(filepath);
                books = JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();
            }

            books.Add(book);

            string jsonWrite = JsonSerializer.Serialize(books);
            File.WriteAllText(filepath, jsonWrite);
        }

        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();

            if (File.Exists(filepath))
            {
                string json = File.ReadAllText(filepath);
                books = JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();
            }

            return books;
        }
    }
}

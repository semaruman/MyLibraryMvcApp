using System.ComponentModel.DataAnnotations;

namespace MyLibraryMvcApp.Areas.Library.Models
{
    public class Book
    {
        public static int sId = 1;
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите название")]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "Введите автора")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Введите дату")]
        public string Date {  get; set; }

        [Required(ErrorMessage = "Введите жанр")]
        public string Genre {  get; set; }

        public override string ToString()
        {
            return $"{Author} {Title} {Date}";
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BookStoreApi.Model
{
    public class BookModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Add title property")]

        public string Title { get; set; }
        public string Description { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BookRegistrationMVC.Models
{
        /// <summary>
        /// Represents a book registration.
        /// </summary>
    public class BookRegistration
    {
        /// <summary>
        /// The book title that is being lent.
        /// </summary>
        [Required(ErrorMessage = "The book title is required")]
        public string Title { get; set; }

        /// <summary>
        /// The author of the book being lent.
        /// </summary>
        [Required(ErrorMessage = "The Authors full name is required")]
        public string Author { get; set; }

        /// <summary>
        /// The ISBN of the book being lent.
        /// </summary>
        [Required(ErrorMessage = "The ISBN is required and must be 10-13 digits long")]
        public long ISBN { get; set; }

        /// <summary>
        /// The price of the book being lent.
        /// </summary>
        [Required(ErrorMessage = "The Price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "The price must be greater than 0.01")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        /// <summary>
        /// The full name of the person checking out the book
        /// </summary>
        [Required(ErrorMessage = "The lenders full name is required")]
        [Display(Name = "Lenders full name")]
        public string FullName { get; set; }
    }
}
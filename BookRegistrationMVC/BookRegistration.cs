﻿using System.ComponentModel.DataAnnotations;

namespace BookRegistrationMVC
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
        [Required]
        public string Author { get; set; }

        /// <summary>
        /// The ISBN of the book being lent.
        /// </summary>
        [Required]
        public long ISBN { get; set; }

        /// <summary>
        /// The price of the book being lent.
        /// </summary>
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "The price must be greater than 0.01")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
    }

}
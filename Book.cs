using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace MVCLibrary {
    public class Book {


        public int BookID { get; set; }

        [Required]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only.")]

        public string CallNumber { get; set; }

        public string Author { get; set; }
    }
}

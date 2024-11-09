using CinemaApplicationWEB.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CinemaApplicationWEB.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is required!")]    
        public string ProfilePictureURL { get; set; }
        [Required(ErrorMessage ="Full Name is required!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full name must be between 3 and 50 chars!")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Required(ErrorMessage ="Biography is required!")]
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }

    }
}

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CinemaApplicationWEB.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Display(Name="Full Name")]
        public string Fullname { get; set; }


    }
}

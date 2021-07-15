using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Hero.Assessment.MVC.Web.Models
{
    public class ContactUs
    {
        [Required]
        [Display(Name ="First name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name ="Last name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email address")]
        public string Email { get; set; }
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Contact message")]
        public string ContactMessage { get; set; }
    }
}
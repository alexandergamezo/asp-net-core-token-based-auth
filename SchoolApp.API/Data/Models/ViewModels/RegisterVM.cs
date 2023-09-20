using System.ComponentModel.DataAnnotations;

namespace SchoolApp.API.Data.Models.ViewModels
{
    public class RegisterVM
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string EmailAdress { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

    }
}

using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Institute_Management.Models
{
    public class ApplicationUser:IdentityUser
    {
        [DisplayName("Your Name")]
        public string? Name { get; set; }
        [DisplayName("Name of Institute")]
        public string? InstituteName { get; set; }
        public string? UserPassword { get; set; }

        [NotMapped]
        public string? UserRole { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Institute_Management.Models
{
    public class Institute
    {
        public int Id { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        [ForeignKey("ApplicationUser")]
        public string? UserId { get; set; }

        [Required]
        [Display(Name ="Institute Name")]
        public string? InstituteName { get; set; }
        [Required]
        public string? FounderName { get; set; }
        [Required]
        public string? AfflifiationNumber { get; set; }
        [Required]
        public string? InstitutionShortCode { get; set; }
        [Required]
        public string? Email { get; set; }
        public string? AlternateEmail {get; set; }
        
        public string? ContactNumber { get; set; }
        public bool CentralInventory { get; set; }
        public string? NumOfCentralInventory { get; set; }
        [Required]
        public string? OfficeNumber { get; set; }
        public string? InstituteType { get; set; }
        [Required]
        public string? PackageType { get; set; }
        public string? BreadNumber { get; set; }
        [Required]
        public string? OfficeAddress { get; set; }
        public string? ProfileImagePath { get; set; }

    }
}

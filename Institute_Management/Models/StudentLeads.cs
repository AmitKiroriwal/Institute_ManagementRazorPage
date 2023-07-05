using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Institute_Management.Models
{
    public class StudentLeads
    {
        public int Id { get; set; }
        
        public DateTime EnquiryOn { get; set; }=DateTime.Now;
        [Required]
        public string? StudentName { get; set; }
        [Required]
        public string? StudentPhone { get; set; }
        [Required]
        public string? StudentEmail { get; set; }
        public string? LeadStatus { get; set; }
        public DateTime NextFollowUp { get; set; }
        [Required]

        public Institute Institute { get; set; }

        [ForeignKey("Institute")]
        public int InstituteId { get; set; }
        public string? CourseOfInterest { get; set; }
        public string? InterestLevel { get; set; }
        public string? EnquiryType { get; set; }
        public string? EnrollmentStatus { get; set; }



    }
}

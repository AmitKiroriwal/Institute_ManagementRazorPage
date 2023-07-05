using System.ComponentModel.DataAnnotations;

namespace Institute_Management.ViewModels
{
    public class EnquiryViewModel
    {
        public DateTime EnquiryOn { get; set; } = DateTime.Now;
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string StudentPhone { get; set; }
        [Required]
        public string StudentEmail { get; set; }
        public string? InstituteName { get; set; }
        public string? CourseOfInterest { get; set; }

    }
}

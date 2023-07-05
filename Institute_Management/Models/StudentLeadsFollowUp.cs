using System.Drawing;

namespace Institute_Management.Models
{
    public class StudentLeadsFollowUp
    {
        public int id { get; set; }
        public StudentLeads StudentLeads { get; set; } 
        public int LeadId { get; set; }

        public string LeadSource { get; set; }
        public DateTime FollowUpDate { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string OutCome { get; set; }
        public string AssignedUser { get; set; }
        public string FollowUpMethod { get; set; }
        public DateTime NextFollowUpDate { get; set; }
        public string NextFollowUpAction { get; set; }

    }
}

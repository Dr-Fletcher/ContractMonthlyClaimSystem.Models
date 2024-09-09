using System;

namespace ContractMonthlyClaimSystem.Models
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string status { get; set; }
        public string SubmissionDocuments { get; set; }
        public int LecturerID { get; set; }

    }
}

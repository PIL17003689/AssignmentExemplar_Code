using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AssignmentExemplar_Code.enums;

namespace AssignmentExemplar_Code
{
    public class MajorIssue : IIssues
    {
        public Guid Issue_Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Progress { get; set; }
        public string TenantInformation { get; set; }

        public MajorIssue(DateTime date, string description, string progress, string tenantInformation)
            // Constructor
        {
            Issue_Id = Guid.NewGuid();
            Date = date;
            Description = description;
            Progress = progress;
            TenantInformation = tenantInformation;
        }

        public override string ToString()
        {
            return $"{Issue_Id} {Date} {Description} {Progress} {TenantInformation}";
        }
    }
}

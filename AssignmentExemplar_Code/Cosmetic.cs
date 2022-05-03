using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentExemplar_Code
{
    internal class Cosmetic : Issues
    {
        public Cosmetic(Guid issue_Id, DateTime date, string description, string progress, string tenantInformation) : base(issue_Id, date, description, progress, tenantInformation)
        {
        }

        public Guid Issue_Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Progress { get; set; }
        public string TenantInformation { get; set; }
    }
}

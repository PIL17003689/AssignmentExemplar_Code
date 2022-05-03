using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentExemplar_Code
{
    internal interface IIssues
    {
        public Guid Issue_Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Progress { get; set; }
        public string TenantInformation { get; set; }

        /*
        public Issues(Guid issue_Id, DateTime date, string description, string progress, string tenantInformation)
        {
            Issue_Id = issue_Id;
            Date = date;
            Description = description;
            Progress = progress;
            TenantInformation = tenantInformation;
        }

        public void SubmitAnIssue(string Issue)
        {
            Console.WriteLine("Enter the issue: ");
            Issue = Console.ReadLine();
        }
        */

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentExemplar_Code
{
    internal class Issues
    {
        public Guid Issue_Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Progress { get; set; }
        public string TenantInformation { get; set; }


        public void SubmitAnIssue(string Issue)
        {
            Console.WriteLine("Enter the issue: ");
            Issue = Console.ReadLine();
        }

    }
}

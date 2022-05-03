using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AssignmentExemplar_Code.enums;

namespace AssignmentExemplar_Code
{
    internal class TeamMember : IPersons, IStaff
    {
        //Persons
        public Guid Person_Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int DateOfBirth { get; set; }
        //Staff
        public string username { get; set; }
        public string password { get; set; }
        public StaffType staffType { get; set; }
    }
}

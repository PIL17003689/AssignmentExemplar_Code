using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AssignmentExemplar_Code.enums;

namespace AssignmentExemplar_Code
{
    internal interface IStaff
    {
        public string username { get; set; }
        public string password { get; set; }
        public StaffType staffType { get; set; }

    }
}

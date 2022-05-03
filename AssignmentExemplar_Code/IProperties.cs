using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentExemplar_Code
{
    public interface IProperties
    {
        public Guid PropertyID { get; set; }
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public string Address { get; set; }
    }
}

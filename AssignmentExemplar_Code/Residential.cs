using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AssignmentExemplar_Code.enums;

namespace AssignmentExemplar_Code
{
    internal class Residential : IProperties
    {
        public Guid PropertyID { get; set; }
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public string Address { get; set; }
        public ResidentialType Type { get; set; }

        public int NoOfBedrooms { get; set; }
        public string OwnerName { get; set; }

        public Residential(string streetName, string cityName, string address, ResidentialType type, int noofbedrooms, string ownerName)
            // Constructor
        {
            PropertyID = Guid.NewGuid();
            StreetName = streetName;
            CityName = cityName;
            Address = address;
            Type = type;
            NoOfBedrooms = noofbedrooms;
            OwnerName = ownerName;
        }

        public override string ToString()
        {
            return $"{PropertyID} {StreetName} {CityName} {Address} {Type} {NoOfBedrooms} {OwnerName}";
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AssignmentExemplar_Code.enums;

namespace AssignmentExemplar_Code
{
    public class Commercial : IProperties
    {
        public Guid PropertyID { get; set; }
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public string Address { get; set; }
        public CommercialType Type { get; set; }

        public double SizeInSqeFt { get; set; }
        public string BusinessName { get; set; }

        public Commercial(string streetName, string cityName, string address, CommercialType type, double sizeInSqeFt, string businessName)
            // Constructor
        {
            PropertyID = Guid.NewGuid();
            StreetName = streetName;
            CityName = cityName;
            Address = address;
            Type = type;
            SizeInSqeFt = sizeInSqeFt;
            BusinessName = businessName;
        }

        public override string ToString()
        {
            return $"{PropertyID} {StreetName} {CityName} {Address} {Type} {SizeInSqeFt} {BusinessName}";
        }
    }
}

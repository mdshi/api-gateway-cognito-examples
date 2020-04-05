using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{

    public class Dependent
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public string PassportNo { get; set; }
        public string SeatNumber { get; set; }
        public bool hasFever { get; set; }
        public bool hasSOB { get; set; }
        public bool hasCough { get; set; }
        public string TravelFrom { get; set; }
        public string TransitFrom { get; set; }
        public string PhoneNo { get; set; }
        public string FlightNumber { get; set; }
        public string selectedLanguage { get; set; }
    }

}

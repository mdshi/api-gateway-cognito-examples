using System;
using System.Collections.Generic;

namespace Api
{
    public class Traveler
    {
        public int TravelerID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public long? Age { get; set; }
        public string Nationality { get; set; }
        public string PassportNo { get; set; }
        public string TravelFrom { get; set; }
        public long? PhoneNo { get; set; }
        public string HotelName { get; set; }
        public long? FlightNumber { get; set; }
        public long? SeatNumber { get; set; }
        public string TransitFrom { get; set; }
        public bool? HasFever { get; set; }
        public bool? HasSob { get; set; }
        public bool? HasCough { get; set; }
        public List<Traveler> Dependents { get; set; }
        public string OtherHotelName { get; set; }
        public string Email { get; set; }
        public string Language { get; set; }
        public string SelectedLanguage { get; set; }

    }

}
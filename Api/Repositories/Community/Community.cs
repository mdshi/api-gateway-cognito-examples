using System;

namespace Api
{
    public class Community
    {
        public int CommunityID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }
        public string Region { get; set; }
        public string SubcityOrZone { get; set; }
        public string Woreda { get; set; }
        public string Kebele { get; set; }
        public string HouseNo { get; set; }
        public string PhoneNo { get; set; }
        public string Occupation { get; set; }
        public DateTime? CallDate { get; set; }
        public string CallerType { get; set; }
        public bool Fever { get; set; }
        public bool Cough { get; set; }
        public bool Headache { get; set; }
        public bool RunnyNose { get; set; }
        public bool UnwellnessFeeling { get; set; }
        public bool BreathingDifficulty { get; set; }
        public bool BodyPain { get; set; }
        public bool TravleHx { get; set; }
        public bool HaveSex { get; set; }
        public bool AnimalMarket { get; set; }
        public bool HealthFacility { get; set; }
        public string ReceiverName { get; set; }
        public string FormStatus { get; set; }
        public string Source { get; set; }
        public int Version { get; set; }
    }
}

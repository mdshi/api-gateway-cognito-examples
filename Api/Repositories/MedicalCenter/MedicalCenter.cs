using System;
using System.Collections.Generic;
namespace Api 
{
public partial class MedicalCenter
{
    public int MedicalID { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string Nationality { get; set; }
    public string Email { get; set; }
    public string Sex { get; set; }
    public long? Age { get; set; }
    public string Region { get; set; }
    public string Subcity { get; set; }
    public string Zone { get; set; }
    public string Woreda { get; set; }
    public string Kebele { get; set; }
    public string HouseNumber { get; set; }
    public string PhoneNumber { get; set; }
    public string Occupation { get; set; }
    public DateTimeOffset? CallDate { get; set; }
    public string CallerType { get; set; }
    public bool? Fever { get; set; }
    public bool? Cough { get; set; }
    public bool? Headache { get; set; }
    public bool? RunnyNose { get; set; }
    public bool? FeelingUnwell { get; set; }
    public bool? ShortnessOfBreath { get; set; }
    public bool? BodyPain { get; set; }
    public bool? TravelHx { get; set; }
    public bool? HaveSex { get; set; }
    public bool? AnimalMarket { get; set; }
    public bool? HealthFacility { get; set; }
    public string ReceiverName { get; set; }
    public string Source { get; set; }
    public string FormStatus { get; set; }
    }

}
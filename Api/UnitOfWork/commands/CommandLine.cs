using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.UnitOfWork.commands
{
    public class CommandLine : ICommandLine
    {
        public string GetCommunity => "Select * from Communities";
        public string GetCommunityById => "Select * from Communities where CommunityID= @CommunityID";
        
        public string RemoveCommunity => "Delete from [Community].[dbo].[Communities] where CommunityID= @CommunityID";

        public string AddCommunity => "INSERT INTO [Community].[dbo].[Communities] (FirstName, LastName, Age, Sex, Language, Region, SubcityOrZone, Sefer, Woreda, Kebele, Occupation, HouseNo, PhoneNo, Latitude, Longitude, Fever, Cough, HasSob, FormStatus, TravleHx, HaveSex, AnimalMarket, HealthFacility, CommunityOccupation) VALUES(@FirstName, @LastName,@Age, @Sex, @Language, @Region, @SubcityOrZone, @Sefer, @Woreda, @Kebele,@Occupation, @HouseNo, @PhoneNo, @Latitude, @Longitude, @Fever, @Cough, @HasSob, @FormStatus, @TravleHx, @HaveSex, @AnimalMarket, @HealthFacility, @CommunityOccupation)";


        public string UpdateCommunity => "Update [Community].[dbo].[Communities] SET FirstName = @FirstName, LastName = @LastName, Sex = @Sex, Language = @Language, Region = @Region, SubcityOrZone = @SubcityOrZone, Sefer = @Sefer, Woreda = @Woreda, Kebele = @Kebele, Occupation = @Occupation, HouseNo = @HouseNo, PhoneNo = @PhoneNo, Latitude = @Latitude, Longitude = @Longitude, Fever = @Fever, Cough = @Cough, HasSob = @HasSob, FormStatus = @FormStatus, TravleHx = @TravleHx, HaveSex = @HaveSex, AnimalMarket = @AnimalMarket, HealthFacility = @HealthFacility, CommunityOccupation = @CommunityOccupation where CommunityID = @CommunityID";

        public CommandLine()
        {
        }
    }
}

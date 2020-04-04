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
        public string AddCommunity => "Insert into  [Community].[dbo].[Communities] ([FirstName], LastName, Age, Sex, Language, Region, SubcityOrZone, Sefer, Woreda, Kebele, Occupation, HouseNo, PhoneNo, Latitude, Longitude, Fever, Cough, HasSob, FormStatus, TravleHx, HaveSex, AnimalMarket, HealthFacility, CommunityOccupation) VALUES(@FirstName, @LastName,@Age, @Sex, @Language, @Region, @SubcityOrZone, @Sefer, @Woreda, @Kebele,@Occupation, @HouseNo, @PhoneNo, @Latitude, @Longitude, @Fever, @Cough, @HasSob, @FormStatus, @TravleHx, @HaveSex, @AnimalMarket, @HealthFacility, @CommunityOccupation)";
        public string UpdateCommunity => "Update [Community].[dbo].[Communities] set FirstName = @FirstName, LastName = @LastName, CreatedDate = GETDATE() where Id =@Id";
        public string RemoveCommunity => "Delete from [Community].[dbo].[Communities] where CommunityID= @CommunityID";
    }
}

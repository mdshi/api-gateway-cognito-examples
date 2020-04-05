using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using static Api.CommunityRepository;

namespace Api.Controllers
{
    //[Route("api/[controller]")]
    [Produces("application/json")]
    [Route("api/v1/communities")]
    [ApiController]
    public class CommunityController : ControllerBase
    {
        private ICommunityRepository _communityRepo;
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public CommunityController(ICommunityRepository communityRepo, IConfiguration configururation)
        {
            _communityRepo = communityRepo;
            _configuration = configururation;
            _connectionString = _configuration.GetConnectionString("Default");

        }

        [HttpGet]
        public ActionResult GellAll()
        {
            var communities = _communityRepo.GetAll();
            return Ok(communities);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Community> GetById(int id)
        {
            var entity = _communityRepo.GetById(id);
            return Ok(entity);
        }

        [HttpPost]
        public ActionResult Create([FromBody] Community entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }
            _communityRepo.Create(entity);
            return Ok(entity);
        }

        [HttpPut("{id}")]
        public ActionResult<Community> Update(Community entity, int id)
        {
           _communityRepo.Update(entity, id);
            return Ok(entity);
            
        }

        //api/communities/{id}
       // [HttpPut("{CmmunityID}")]
        public async Task<IActionResult> Put([FromBody] Community entity,int id)
        {

            
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var sqlStatement = @"Update [Community].[dbo].[Communities] SET FirstName = @FirstName, 
                    LastName = @LastName, Sex = @Sex, Language = @Language, Region = @Region, SubcityOrZone = @SubcityOrZone, 
                    Sefer = @Sefer, Woreda = @Woreda, Kebele = @Kebele, Occupation = @Occupation, HouseNo = @HouseNo, PhoneNo = @PhoneNo, 
                    Latitude = @Latitude, Longitude = @Longitude, Fever = @Fever, Cough = @Cough, HasSob = @HasSob, FormStatus = @FormStatus, 
                    TravleHx = @TravleHx, HaveSex = @HaveSex, AnimalMarket = @AnimalMarket, HealthFacility = @HealthFacility,
                    CommunityOccupation = @CommunityOccupation where CommunityID = @CommunityID";
                await connection.ExecuteAsync(sqlStatement, entity);
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Community> Delete(int id)
        {
            _communityRepo.Delete(id);
            return Ok();
        }
    }
}
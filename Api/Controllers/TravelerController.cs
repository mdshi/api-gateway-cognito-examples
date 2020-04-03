using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
  //  [Route("api/[controller]")]
    [Produces("application/json")]
    [Route("api/travelers")]
   // [ApiController]
    public class TravelerControler : ControllerBase
    {
        private ITravelerRepository _travelerRepo;

        public TravelerControler(ITravelerRepository travelerRepo)
        {
            _travelerRepo = travelerRepo;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            var community = await _travelerRepo.GetAllAsync();
            return Newtonsoft.Json.JsonConvert.SerializeObject(community);
        }

        [HttpPost]
        public IActionResult Create(Traveler traveler)
        {
            _travelerRepo.InsertAsync(traveler);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Traveler traveler)
        {
            _travelerRepo.UpdateAsync(traveler);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int travelerID)
        {
            _travelerRepo.DeleteAsync(travelerID);
            return Ok();
        }
    }
}
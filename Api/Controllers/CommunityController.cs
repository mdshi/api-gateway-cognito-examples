using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    //[Route("api/[controller]")]
    [Produces("application/json")]
    [Route("api/v1/communities")]
    [ApiController]
    public class CommunityController : ControllerBase
    {
        private ICommunityRepository _communityRepo;

        public CommunityController(ICommunityRepository communityRepo)
        {
            _communityRepo = communityRepo;
        }

        [HttpPost]
        public ActionResult Create([FromBody] Community entity)
        {
            _communityRepo.Create(entity);
            return Ok(entity);
        }
    }
}
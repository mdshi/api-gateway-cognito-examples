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

       
    }
}
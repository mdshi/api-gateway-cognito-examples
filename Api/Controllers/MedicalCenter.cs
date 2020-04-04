using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    //[Route("api/[controller]")]
    [Produces("application/json")]
    [Route("api/medicalcenters")]
    //[ApiController]
    public class MedicalCenterController : ControllerBase
    {
        private IMedicalCenterRepository _medicalRepo;

        public MedicalCenterController(IMedicalCenterRepository medicalRepo)
        {
            _medicalRepo = medicalRepo;
        }

  
    }
}
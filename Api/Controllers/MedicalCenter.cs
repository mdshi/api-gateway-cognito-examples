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

        [HttpGet]
        public async Task<string> Get()
        {
            var medical = await _medicalRepo.GetAllAsync();
            return Newtonsoft.Json.JsonConvert.SerializeObject(medical);
        }

        [HttpPost]
        public IActionResult Create(MedicalCenter medical)
        {
            _medicalRepo.InsertAsync(medical);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, MedicalCenter medical)
        {
            _medicalRepo.UpdateAsync(medical);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _medicalRepo.DeleteAsync(id);
            return Ok();
        }
    }
}
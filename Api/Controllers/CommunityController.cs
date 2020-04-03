﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
  //  [Route("api/[controller]")]
    [Produces("application/json")]
    [Route("api/communities")]
   // [ApiController]
    public class CommunityController : ControllerBase
    {
        private ICommunityRepository _communityRepo;

        public CommunityController(ICommunityRepository communityRepo)
        {
            _communityRepo = communityRepo;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            var community = await _communityRepo.GetAllAsync();
            return Newtonsoft.Json.JsonConvert.SerializeObject(community);
        }

        [HttpPost]
        public IActionResult Create(Community community)
        {
            _communityRepo.InsertAsync(community);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Community community)
        {
            _communityRepo.UpdateAsync(community);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _communityRepo.DeleteAsync(id);
            return Ok();
        }
    }
}
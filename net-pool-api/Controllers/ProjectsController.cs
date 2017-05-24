using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace net_pool_api.Controllers
{
    using Models;
    [Route("api/[controller]")]
    public class ProjectsController : Controller
    {
        // GET api/projects
        [HttpGet]
        public async Task<IEnumerable<ProjectViewModel>> Get()
        {
            return new ProjectViewModel[] {
                new ProjectViewModel(),
                new ProjectViewModel()
             };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ProjectViewModel> Get(Guid id)
        {
            return new ProjectViewModel();
        }

        // GET api/values/5/Updates
        [HttpGet("{id}/Updates")]
        public async Task<IEnumerable<UpdateViewModel>> GetUpdates(Guid id)
        {
            return new UpdateViewModel[]{
                new UpdateViewModel(),
                new UpdateViewModel(),
                new UpdateViewModel()
            };
        }
        // GET api/values/5/Updates
        [HttpGet("{id}/Candidates")]
        public async Task<IEnumerable<ResourceViewModel>> GetCandidates(Guid id)
        {
            return new ResourceViewModel[]{
                new ResourceViewModel(),
                new ResourceViewModel(),
                new ResourceViewModel()
            };
        }

        // POST api/values
        [HttpPost]
        public async void Post([FromBody]ProjectInputModel value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async void Put(Guid id, [FromBody]ProjectInputModel value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async void Delete(Guid id)
        {
        }
    }
}

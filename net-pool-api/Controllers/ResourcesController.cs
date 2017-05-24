using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetPoolService.Services;
using NetPoolService.Models;

namespace net_pool_api.Controllers
{
    using Models;
    [Route("api/[controller]")]
    public class ResourcesController : Controller
    {
        private readonly IResourceService _resourceService;
        private readonly Func<Resource,ResourceViewModel> _resourceProjection = sm => new ResourceViewModel{
                    Id = sm.Id,
                    Name = sm.Name,
                    LastOneOnOne = sm.LastOneOnOne
                };
        public ResourcesController(IResourceService resourceService){
            _resourceService = resourceService;
        }

        // GET api/resources
        [HttpGet]
        public async Task<IEnumerable<ResourceViewModel>> Get()
        {
            var serviceModels = await _resourceService.AllResources();
            return serviceModels.Select(_resourceProjection);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ResourceViewModel> Get(Guid id)
        {
            var serviceModel = await _resourceService.GetResource(id);
            return _resourceProjection(serviceModel);
        }

        // POST api/values
        [HttpPost]
        public async void Post([FromBody]ResourceInputModel value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async void Put(Guid id, [FromBody]ResourceInputModel value)
        {
        }
        // PUT api/Resources/5/OneOnOne
        [HttpPut("{id}/OneOnOne")]
        public async void PutOneOnOne(Guid id, [FromBody]ResourceInputModel value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async void Delete(Guid id)
        {
        }
    }
}

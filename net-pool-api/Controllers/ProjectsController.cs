using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace net_pool_api.Controllers
{
    using Models;
    using NetPoolService.Services;
    using NetPoolService.Models;

    [Route("api/[controller]")]
    public class ProjectsController : Controller
    {
        private readonly IProjectService _projectService;
        private static readonly Func<Update, UpdateViewModel> _updateProjection = sm => new UpdateViewModel{
            TimeOfUpdate=sm.UpdateTime,
            Comments = sm.Comments
        };
        private readonly Func<Project,ProjectViewModel> _projectProjection = sm => new ProjectViewModel{
                    Id = sm.Id,
                    Name = sm.Name,
                    LastUpdate = sm.Updates.OrderByDescending( u => u.UpdateTime ).Select(_updateProjection).FirstOrDefault()
                };
        private readonly Func<Resource,ResourceViewModel> _resourceProjection = sm => new ResourceViewModel{
                    Id = sm.Id,
                    Name = sm.Name,
                    LastOneOnOne = sm.LastOneOnOne
                };

        public ProjectsController(IProjectService projectService){
            _projectService = projectService;
        }
        // GET api/projects
        [HttpGet]
        public async Task<IEnumerable<ProjectViewModel>> Get()
        {
            var serviceModels = await _projectService.AllProjects();
            return serviceModels.Select(_projectProjection);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ProjectViewModel> Get(Guid id)
        {
            var serviceModel = await _projectService.GetProject(id);
            return _projectProjection(serviceModel);
        }

        // GET api/values/5/Updates
        [HttpGet("{id}/Updates")]
        public async Task<IEnumerable<UpdateViewModel>> GetUpdates(Guid id)
        {
            var serviceModels = await _projectService.GetProjectUpdates(id);
            return serviceModels.Select(_updateProjection);
        }
        // GET api/values/5/Updates
        [HttpGet("{id}/Candidates")]
        public async Task<IEnumerable<ResourceViewModel>> GetCandidates(Guid id)
        {
            var serviceModels = await _projectService.GetProjectResources(id);
            return serviceModels.Select(_resourceProjection);
        }

        // POST api/values
        [HttpPost]
        public async Task<Guid> Post([FromBody]ProjectInputModel value)
        {
            var newId = await _projectService.AddProject(value.Name,value.Priority,value.Likelyhood);
            return newId;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async void Put(Guid id, [FromBody]ProjectInputModel value)
        {
            await _projectService.UpdateProject(id, value.Name, value.Priority, value.Likelyhood);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async void Delete(Guid id)
        {
            await _projectService.DeleteProject(id);
        }
        // POST api/Project/5/resourceID
        [HttpPost("{projectId}/{resourceId}")]
        public async void AssignResource(Guid projectId,Guid resourceId)
        {
            await _projectService.AssignResource(projectId,resourceId);
        }
        // DELETE api/Project/5/resourceID
        [HttpDelete("{projectId}/{resourceId}")]
        public async void DeassignResource(Guid projectId,Guid resourceId)
        {
            await _projectService.DeAssignResource(projectId,resourceId);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetPoolService;
namespace NetPoolService.Services{
    using Models;
    public class ProjectService : IProjectService
    {
        public async Task AddComment(Guid id, string comment)
        {
            throw new NotImplementedException();
        }

        public async Task<Guid> AddProject(string name, int priority, float likelyhood)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Project>> AllProjects()
        {
            throw new NotImplementedException();
        }

        public async Task AssignResource(Guid projectId, Guid resourceId)
        {
            throw new NotImplementedException();
        }

        public async Task DeAssignResource(Guid projectId, Guid resourceId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProject(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Project> GetProject(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Resource>> GetProjectResources(Guid projectId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Update>> GetProjectUpdates(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateProject(Guid id, string name, int priority, float likelyhood)
        {
            throw new NotImplementedException();
        }
    }
}
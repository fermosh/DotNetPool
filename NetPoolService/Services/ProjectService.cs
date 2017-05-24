using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetPoolService;
namespace NetPoolService.Services{
    using Models;
    public class ProjectService : IProjectService
    {
        public void AddComment(Guid id, string comment)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> AddProject(string name, int priority, float likelyhood)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> AllProjects()
        {
            throw new NotImplementedException();
        }

        public void AssignResource(Guid projectId, Guid resourceId)
        {
            throw new NotImplementedException();
        }

        public void DeAssignResource(Guid projectId, Guid resourceId)
        {
            throw new NotImplementedException();
        }

        public void DeleteProject(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetProject(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Resource>> GetProjectResources(Guid projectId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProject(Guid id, string name, int priority, float likelyhood)
        {
            throw new NotImplementedException();
        }
    }
}
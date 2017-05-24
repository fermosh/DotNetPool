using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetPoolService.Services{
    using Models;
    public interface IProjectService
    {
        Task<IEnumerable<Project>> AllProjects();
        Task<Project> GetProject(Guid id);
        Task<IEnumerable<Resource>> GetProjectResources(Guid projectId);
        Task<Guid> AddProject(string name,int priority, float likelyhood);
        Task UpdateProject(Guid id, string name, int priority, float likelyhood);
        Task AddComment(Guid id, string comment);
        Task AssignResource(Guid projectId, Guid resourceId);
        Task DeAssignResource(Guid projectId, Guid resourceId);
        Task DeleteProject(Guid id);
        Task<IEnumerable<Update>> GetProjectUpdates(Guid id);
    }
}
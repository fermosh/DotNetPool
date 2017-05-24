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
        void UpdateProject(Guid id, string name, int priority, float likelyhood);
        void AddComment(Guid id, string comment);
        void AssignResource(Guid projectId, Guid resourceId);
        void DeAssignResource(Guid projectId, Guid resourceId);
        void DeleteProject(Guid id);
    }
}
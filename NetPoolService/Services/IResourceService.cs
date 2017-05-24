using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetPoolService.Services{
    using Models;
    public interface IResourceService
    {
        Task<IEnumerable<Resource>> AllResources();
        Task<Resource> GetResource(Guid id);
        Task<IEnumerable<Project>> GetResourceProjects(Guid resourceId);
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetPoolService;
namespace NetPoolService.Services{
    using Models;
    public class ResourceService : IResourceService
    {
        public async Task<IEnumerable<Resource>> AllResources()
        {
            return new Resource[]{
                new Resource(),
                new Resource(),
                new Resource(),
                new Resource(),
                new Resource(),
                new Resource{ Id=new Guid(),Name="John Doe" ,LastOneOnOne=DateTime.Now }
            };
        }

        public async Task<Resource> GetResource(Guid id)
        {
            return new Resource{ Id=new Guid(),Name="John Doe" ,LastOneOnOne=DateTime.Now };
        }

        public async Task<IEnumerable<Project>> GetResourceProjects(Guid resourceId)
        {
            return new Project[]{
                new Project(),
                new Project(),
                new Project(),
                new Project(),
                new Project()
            };
        }
    }
}
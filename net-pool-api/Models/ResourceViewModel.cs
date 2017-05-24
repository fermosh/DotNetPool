using System;

namespace net_pool_api.Models
{
    public class ResourceViewModel
    {
        public Guid Id {get;set;}
        public string Name {get;set;}
        public DateTime LastOneOnOne {get;set;}
    }
}
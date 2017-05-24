using System;

namespace net_pool_api.Models
{
    public class ProjectViewModel
    {
        public Guid Id{get;set;}
        public string Name {get;set;}
        public int Priority{get;set;}
        public float Likelyhood {get;set;}
        public UpdateViewModel LastUpdate {get;set;}
    }
}
using System;
using System.Collections.Generic;

namespace NetPoolService.Models.Data
{
    public class Resource
    {
        public Guid Id{get;set;}
        public string Name{get;set;}
        public DateTime LastOneOnOne {get;set;}
        public virtual ICollection<Project> Projects{get;set;}
    }
}
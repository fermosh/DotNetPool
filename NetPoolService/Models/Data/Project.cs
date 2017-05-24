using System;
using System.Collections.Generic;

namespace NetPoolService.Models.Data{
    public class Project{
       public Guid Id{get;set;}
        public string Name {get;set;}
        public int Priority{get;set;}
        public float Likelyhood {get;set;}
        public virtual ICollection<Update> Updates {get;set;}
        public virtual ICollection<Resource> Resources{get;set;}
    }
}
using System;
using System.Collections.Generic;

namespace NetPoolService.Models{
    public class Project{
        public Guid Id{get;set;}
        public string Name {get;set;}
        public int Priority{get;set;}
        public float Likelyhood {get;set;}
        public IEnumerable<Update> Updates {get;set;}

    }
}
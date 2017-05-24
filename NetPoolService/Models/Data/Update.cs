using System;

namespace NetPoolService.Models.Data
{
    public class Update
    {
        public Guid Id{get;set;}
        public DateTime UpdateTime{get;set;}
        public string Comments {get;set;}
        public Guid ProjectId {get;set;}
        public virtual Project Project{get;set;}
    }
}
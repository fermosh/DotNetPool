using System;

namespace NetPoolService.Models
{
    public class Resource
    {
        public Guid Id{get;set;}
        public string Name{get;set;}
        public DateTime LastOneOnOne {get;set;}
    }
}
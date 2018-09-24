using System;

namespace AssignmentsNetcore.Models.Database
{
    public class Role : BaseEntity
    {
        public string Name { get; set;}
        public bool Active { get; set;}
        public Tech Tech { get; set;}
    }
}
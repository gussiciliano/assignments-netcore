using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignmentsNetcore.Models.Database
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

using System;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class BaseEntityViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
using System;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class BaseEntityViewModel
    {
        public BaseEntityViewModel() { }

        public BaseEntityViewModel(BaseEntity m)
        {
            this.Id = m.Id;
            this.CreatedAt = m.CreatedAt;
            this.UpdatedAt = m.UpdatedAt;
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
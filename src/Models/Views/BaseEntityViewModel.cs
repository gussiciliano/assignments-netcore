using System;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class BaseEntityViewModel
    {
        public BaseEntityViewModel() { }
        public BaseEntityViewModel(BaseEntity entity)
        {
            this.Id = entity.Id;
            this.CreatedAt = entity.CreatedAt;
            this.UpdatedAt = entity.UpdatedAt;
        }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
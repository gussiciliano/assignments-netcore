using System;
using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class TabViewModel : BaseEntityViewModel
    {
        public TabViewModel() : base() { }

        public TabViewModel(Tab tab) : base(tab)
        {
            this.Name = tab.Name;
            this.StartDate = tab.StartDate;
            this.EndDate = tab.EndDate;
            this.Client = new ClientViewModel(tab.Client);
            this.ProjectStatus = Enum.GetName(typeof(ProjectStatus), tab.ProjectStatus);
        }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public ClientViewModel Client { get; set; }
        [Required]
        public string ProjectStatus { get; set; }
    }
}

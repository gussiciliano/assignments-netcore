using System.Collections.Generic;

namespace AssignmentsNetcore.Models.Views
{
    public class CountryViewModel : BaseEntityViewModel
    {
        public string Name { get; set; }
        public ICollection<OfficeViewModel> Offices { get; set; }
    }
}

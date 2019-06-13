using System.ComponentModel.DataAnnotations;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class OfficeViewModel : BaseEntityViewModel
    {
        public OfficeViewModel() : base() { }

        public OfficeViewModel(Office office) : base(office)
        {
            this.Country = new CountryViewModel(office.Country);
            this.Name = office.Name;
            this.Active = office.Active;
            this.Address = office.Address;
        }

        [Required]
        public CountryViewModel Country { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool Active { get; set; }
        [Required]
        public string Address { get; set; }
    }
}

using AssignmentsNetcore.Models.Database;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace AssignmentsNetcore.Models.Views
{
    public class OfficeFormViewModel : OfficeViewModel
    {
        public OfficeFormViewModel(Office office, IEnumerable<Country> countries) : base()
        {
            this.Name = office.Name;
            this.Active = office.Active;
            this.Address = office.Address;
            this.Country = new CountryViewModel(office.Country);
            this.Countries = countries.Select(c => new SelectListItem(c.Name, c.Id.ToString()));
        }
        [Required]
        public IEnumerable<SelectListItem> Countries { get; set; }
    }
}
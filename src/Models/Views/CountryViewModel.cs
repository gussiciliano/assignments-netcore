using System.Collections.Generic;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class CountryViewModel : BaseEntityViewModel
    {
        public CountryViewModel() : base() { }

        public CountryViewModel(Country country) : base(country)
        {
            this.Name = country.Name;
        }

        public string Name { get; set; }
    }
}

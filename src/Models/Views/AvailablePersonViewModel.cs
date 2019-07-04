using System.Collections.Generic;
using AssignmentsNetcore.Models.Database;

namespace AssignmentsNetcore.Models.Views
{
    public class AvailablePersonViewModel
    {
        public Person Person { get; set; }
        public IEnumerable<PeriodViewModel> Periods { get; set; }
    }
}

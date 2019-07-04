using System;

namespace AssignmentsNetcore.Models.Views
{
    public class PeriodViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int AvailableWorkload { get; set; }
    }
}

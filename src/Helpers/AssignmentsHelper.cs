using System;
using System.Collections.Generic;
using System.Linq;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Models.Views;

namespace AssignmentsNetcore.Helpers
{
    public static class AssignmentsHelper
    {
        public static IEnumerable<AvailablePersonViewModel> GetAvailableDevelopers(IEnumerable<Person> developers,
                                                                                DateTime startDate,
                                                                                DateTime endDate) =>
            developers.Select(dev => new AvailablePersonViewModel
            {
                Person = dev,
                Periods = GetPeriodsInAssignments(dev.Assignments.Where(a => 
                    (a.StartDate <= startDate && a.EndDate >= endDate) ||
                    (a.StartDate <= startDate && a.EndDate >= startDate && a.EndDate <= endDate) ||
                    (a.StartDate >= startDate && a.EndDate <= endDate) ||
                    (a.StartDate >= startDate && a.StartDate <= endDate && a.EndDate >= endDate)
                ), startDate, endDate),
            });

        private static IEnumerable<PeriodViewModel> GetPeriodsInAssignments(IEnumerable<Assignment> assignments,
                                                                            DateTime projectStartDate,
                                                                            DateTime projectEndDate)
        {
            var devWorkload = assignments.First().Person.Workload;
            var periods = new List<PeriodViewModel>();
            var currentDate = projectStartDate;
            while (currentDate < projectEndDate)
            {
                (DateTime nextDate, bool isStartDate) = GetNextDate(assignments, currentDate);
                if (nextDate == DateTime.MaxValue) throw new Exception("Pinchó");
                var periodWorkload = assignments.Where(a => a.StartDate <= currentDate && a.EndDate > currentDate).Sum(a => a.Workload);
                if (periodWorkload <= devWorkload)
                {
                    periods.Add(new PeriodViewModel
                    {
                        StartDate = currentDate,
                        EndDate = nextDate,
                        AvailableWorkload = devWorkload - periodWorkload,
                    });
                }
                currentDate = nextDate;
            }
            return periods;
        }

        private static (DateTime nextDate, bool isStartDate) GetNextDate(IEnumerable<Assignment> assignments, DateTime currentDate)
        {
            var currentDiff = long.MaxValue;
            var nextDate = DateTime.MaxValue;
            var isStartDate = false;
            foreach (var assignment in assignments)
            {
                if (assignment.StartDate <= currentDate)
                {
                    // la asignacion empezo antes del proyecto actual
                    if (currentDate >= assignment.EndDate) continue; // la asignación terminó.
                    var diff = assignment.EndDate.Ticks - currentDate.Ticks;
                    if (diff < currentDiff)
                    {
                        currentDiff = diff;
                        nextDate = assignment.EndDate;
                        isStartDate = false;
                    }
                }
                else
                {
                    // la asignación aun no empezó
                    var diff = assignment.StartDate.Ticks - currentDate.Ticks;
                    if (diff < currentDiff)
                    {
                        currentDiff = diff;
                        nextDate = assignment.StartDate;
                        isStartDate = true;
                    }
                }
            }
            return (nextDate, isStartDate);
        }
    }
}

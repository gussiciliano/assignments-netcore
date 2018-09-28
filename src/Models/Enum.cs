using System;

namespace AssignmentsNetcore.Models
{
    public enum ProjectStatus
    {
        // TODO: Complete
        ProductThinking = 1,
        Developing = 2,
        Production = 3,
        Maintenance = 4,
        Closed = 5,
    }

    public enum RoleType
    {
        // TODO: Complete with more role types
        TM = 1,
        PL = 2,
        ScrumMaster = 3,
        PA = 4,
        LeadDeveloper = 5,
        TL = 6,
        Developer = 7,
    }
}

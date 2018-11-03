using System;

namespace AssignmentsNetcore.Models
{
    public enum ProjectStatus
    {
        ProductThinking = 1,
        Developing = 2,
        Production = 3,
        Maintenance = 4,
        Closed = 5,
    }

    public enum JobRoleType
    {
        Lead = 1,
        Management = 2,
        Referent = 3,
        Backend = 4,
        Frontend = 5,
    }

    public enum Country
    {
        Argentina = 1,
        Colombia = 2,
        Mexico = 3,
        USA = 4,
    }
}

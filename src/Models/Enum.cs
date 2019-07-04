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

    public enum TrainingStatus
    {
        OnGoing = 1,
        Finished = 2,
        Closed = 3,
    }

    public enum ToolStatus
    {
        OnGoing = 1,
        Finished = 2,
        Maintenance = 3,
        Closed = 4,
    }

    public enum JobRoleType
    {
        Lead = 1,
        Management = 2,
        Referent = 3,
        Backend = 4,
        Frontend = 5,
    }

    public enum DevRole
    {
        LeadDeveloper = 1,
        Developer = 2,
        TechnicalLeader = 3,
    }
}

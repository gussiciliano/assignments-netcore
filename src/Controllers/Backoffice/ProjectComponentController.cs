using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AssignmentsNetcore.Models.Database;
using AssignmentsNetcore.Repositories.Database;

namespace AssignmentsNetcore.Controllers
{
    public class ProjectComponentController : CRUDController<ProjectComponent, ProjectComponentViewModel>
    {
        
    }
}

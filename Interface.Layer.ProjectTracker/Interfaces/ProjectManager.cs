using Interface.Layer.ProjectTracker.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Layer.ProjectTracker.Interfaces
{
    public interface IProjectManager
    {
         List<Project> GetAllProjects();
         Project  GetProject(int ID);
         int CreateProject(Project p);
         int UpdateProject(Project p);
    }
}

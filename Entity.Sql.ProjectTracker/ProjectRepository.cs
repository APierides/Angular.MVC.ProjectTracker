using Interface.Layer.ProjectTracker.Interfaces;
using Interface.Layer.ProjectTracker.Models;
using System;
using System.Collections.Generic;

namespace Entity.Sql.ProjectTracker
{
    public class ProjectRepository : IProjectRepository
    {
        public List<Project> GetAllProjects()
        {
            var projects = new List<Project>() {
                                new  Project(){ID=1, StartDate = DateTime.Now,   Title = "Static Sample",    Status = "I",  Priority = "H" },
                              new  Project(){ID=2, StartDate = DateTime.Now,   Title = "Static Sample 2",    Status = "C",  Priority = "M" }
                                };

            return projects;
        }
        public Project GetProject(int ID) { return null; }
        public int CreateProject(Project p) { return 0; }
        public int UpdateProject(Project p) { return 0; }
    }
}

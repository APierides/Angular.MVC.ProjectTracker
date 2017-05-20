﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.Layer.ProjectTracker.Interfaces;
using Interface.Layer.ProjectTracker.Models;
using Entity.SQL.ProjectTracker.DataModel;

namespace Entity.Sql.ProjectTracker
{
    public class ProjectRepository : IProjectRepository
    {
        public List<Project> GetAllProjects()
        {
            var projects = new List<Project>() {
                                new  Project(){ID=1, StartDate = DateTime.Now.AddDays(-3),
                                    Title = "Static Sample",
                                    Status = "I",  Priority = "H" },
                              new  Project(){ID=2, StartDate = DateTime.Now.AddDays(-2) ,   Title = "Static Sample 2",    Status = "C",  Priority = "M" }
                                };

            return projects;
        }
        public Project GetProject(int ID)
        {
            var proj = new Project();
            using (ProjectTrackerContainer container = new ProjectTrackerContainer())
            {
                var dProj = container.dProjects.Find(ID);
                if (dProj == null)
                    return null;
                
                proj = new Project()
                {
                    Title = dProj.Title,
                    DueDate = dProj.DueDate,
                    Priority = dProj.Priority,
                    Status = dProj.Status,
                    StartDate = dProj.StartDate,
                    ID = dProj.Id,
                };
            }
            return proj;
        }
        public int CreateProject(Project p)
        {
            ProjectTrackerContainer container = new ProjectTrackerContainer();
            var proj = new dProject()
            {
                Title = p.Title,
                DueDate = p.DueDate,
                StartDate = p.StartDate,
                Status = p.Status,
                Priority = p.Priority
            };
            container.dProjects.Add(proj);
            container.SaveChanges();

            return container.dProjects.Where(x => x.Title == proj.Title && x.Status == proj.Status).Select(x => x.Id).SingleOrDefault();
        }

        public int UpdateProject(Project p) { return 0; }
    }
}

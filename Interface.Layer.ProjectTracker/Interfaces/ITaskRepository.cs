using Interface.Layer.ProjectTracker.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Layer.ProjectTracker.Interfaces
{
    public interface ITaskRepository
    {
      
            List<Task> GetAllTaskss();
            Task GetTask(int ID);
            int CreateTask(Task p);
            int UpdateTask(Task p);
        
    }
}

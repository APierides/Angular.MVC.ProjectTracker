using Interface.Layer.ProjectTracker.Interfaces;
using Interface.Layer.ProjectTracker.Models;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular.MVC.ProjectTracker.API
{
    public class TaskController : ApiController
    {
        // GET api/<controller>
     
        private ITaskRepository _taskRepository;
        [Dependency]
        public ITaskRepository TaskRepository {
            get { return _taskRepository; }
            set { _taskRepository = value; }
        }
        public List<Task> Get()
        {
            return null;
        }

        // GET api/<controller>/5
        public Task Get(int id)
        {
            return null;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
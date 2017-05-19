using Interface.Layer.ProjectTracker.Interfaces;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular.MVC.ProjectTracker.API
{
    public class ProjectController : ApiController
    {
        [Dependency]
        private IProjectRepository _ProjectManager { get; set; }
        // GET api/<controller>

        public ProjectController (IProjectRepository projectManager)
        {
            _ProjectManager = projectManager;
        }
        public IEnumerable<object> Get()
        
        {

           return _ProjectManager.GetAllProjects();
 

           // return projects;
        }

        private void BuildUpUnityContainer()
        {

        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
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
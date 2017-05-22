using Interface.Layer.ProjectTracker.Interfaces;
using Interface.Layer.ProjectTracker.Models;
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
        private IProjectRepository _projectRepository;

        [Dependency]
        public IProjectRepository projectRepository {
            get { return _projectRepository; }
            set { _projectRepository = value; }
        }
        // GET api/<controller>


        //constructor injection

        //public ProjectController (IProjectRepository projectManager)
        //{
        //    _projectRepository = projectManager;
        //}
        public IEnumerable<object> Get()

        {
            return _projectRepository.GetAllProjects();

        }

        public object GetProject(int id)

        {

            return _projectRepository.GetProject(id);


            // return projects;
        }

        private void BuildUpUnityContainer()
        {

        }



        // POST api/<controller>
        public void Post([FromBody]Project proj)
        {
            _projectRepository.CreateProject(proj);
        }

        // PUT api/<controller>/5
        [HttpPut]   
        public void Put([FromBody]Project value)
        {
            _projectRepository.UpdateProject(value);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
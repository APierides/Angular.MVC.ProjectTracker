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
        private IProjectManager _ProjectManager { get; set; }
        // GET api/<controller>
        public IEnumerable<object> Get()
        //{   var projects = new  { startdate: new Date(), title: 'Static Sample', status: 'I', priority: 'H' },
        //                    new  { startdate: new Date(), title: 'Static Sample 2', status: 'C', priority: 'M' }];
        {
            BuildUpUnityContainer(); 

            var projects = new[] {
                                new { StartDate = DateTime.Now,   Title = "Static Sample",    Status = "I",  Priority = "H" },
                                new { StartDate = DateTime.Now,   Title = "Static Sample 2",    Status = "C",  Priority = "M" }
                                };

            return projects;
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
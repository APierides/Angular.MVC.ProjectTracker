using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Layer.ProjectTracker.Models
{
    public class Component
    {
     
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Status { get; set; }
            public string Coordinator { get; set; }
            public int ProjectID { get; set; }
       
    }
}

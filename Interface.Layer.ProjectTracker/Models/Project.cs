using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Layer.ProjectTracker.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
    }
}

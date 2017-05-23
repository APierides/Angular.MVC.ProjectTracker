using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Layer.ProjectTracker.Models
{
    public class Task
    {
        public int Id { get; set; }
                public string Title { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? DateCompleted { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int ComponentId { get; set; }
    }
}

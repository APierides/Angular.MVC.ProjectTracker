//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity.SQL.ProjectTracker.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class dProject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
    }
}
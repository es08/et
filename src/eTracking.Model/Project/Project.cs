using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTracking.Model
{
    public class Project
    {
        public Project()
        {
            this.ProjectStaffs = new List<Project_Staff>();
            this.Activities = new List<Activity>();
        }

        public int ID { get; set; }
        public int Year { get; set; }
        public string Name_TH { get; set; }
        public string Name_EN { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Amount { get; set; }
        public double UsedAmount { get; set; }
        public double Balance { get; set; }
        public int CreatorID { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int StatusID { get; set; }
        public ProjectStatus Status { get; set; }

        [ForeignKey("CreatorID")]
        public Staff Creator { get; set; }
        public virtual List<Project_Staff> ProjectStaffs { get; set; }
        public virtual List<Activity> Activities { get; set; }
    }
}

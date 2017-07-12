using eTracking.Model;
using System;
using System.Collections.Generic;

namespace eTracking.Web.ViewModels
{
    public class ProjectViewModel
    {
        public ProjectViewModel()
        {
            this.ProjectStaffs = new List<Project_StaffViewModel>();
            this.Activities = new List<ActivityViewModel>();
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
        public StaffViewModel Creator { get; set; }
        public virtual List<Project_StaffViewModel> ProjectStaffs { get; set; }
        public virtual List<ActivityViewModel> Activities { get; set; }
    }
}

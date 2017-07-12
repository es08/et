using eTracking.Model;
using System;
using System.Collections.Generic;

namespace eTracking.Web.ViewModels
{
    public class ActivityViewModel
    {
        public ActivityViewModel()
        {
            this.WorkFlows = new List<Activity_WorkFlowViewModel>();
        }

        public int ID { get; set; }
        public int ProjectID { get; set; }
        public int BorrowingTypeID { get; set; }
        public int CreatorID { get; set; }
        public int ActivatorID { get; set; }

        public string Name_TH { get; set; }
        public string Name_EN { get; set; }
        public string FilePath { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Amount { get; set; }
        public double UsedAmount { get; set; }
        public double Balance { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        // public Project Project { get; set; }
        public BorrowingType BorrowingType { get; set; }

        public StaffViewModel Activator { get; set; }

        public StaffViewModel Creator { get; set; }

        public virtual List<Activity_WorkFlowViewModel> WorkFlows { get; set; }
    }
}

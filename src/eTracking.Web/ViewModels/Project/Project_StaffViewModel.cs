using eTracking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTracking.Web.ViewModels
{
    public class Project_StaffViewModel
    {
        public int ProjectID { get; set; }
        public StaffViewModel Staff { get; set; }
        public double Percentage { get; set; }
    }
}

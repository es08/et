using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTracking.Model
{
    public class Project_Staff
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectID { get; set; }
        public Project Project { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StaffID { get; set; }
        public Staff Staff{ get; set; }
        public double Percentage { get; set; }
    }
}

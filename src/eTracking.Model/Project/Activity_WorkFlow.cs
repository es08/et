using System.ComponentModel.DataAnnotations.Schema;

namespace eTracking.Model
{
    public class Activity_WorkFlow
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ActivityID { get; set; }
        public Activity Activity { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WorkFlowID { get; set; }
        public WorkFlow WorkFlow { get; set; }
    }
}

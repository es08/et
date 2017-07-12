using System;
using System.ComponentModel.DataAnnotations;

namespace eTracking.Web.ViewModels
{
    public class WorkFlowViewModel
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Name in Thai")]
        public string Name_TH { get; set; }
        public string Name_EN { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Sequence { get; set; }
        [Required]
        public bool Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}

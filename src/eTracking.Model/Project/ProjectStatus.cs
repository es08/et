using eTracking.Model.Enum;
using System;

namespace eTracking.Model
{
    public class ProjectStatus 
    {
        public int ID { get; set; }
        public string Name_TH { get; set; }
        public string Name_EN { get; set; }
        public ActiveStatus Active { get; set; }
        public DateTime Created { get; set; }
    }
}

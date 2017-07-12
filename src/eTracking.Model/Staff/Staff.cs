using eTracking.Model.Enum;
using System;
using System.Collections.Generic;

namespace eTracking.Model
{
    public class Staff
    {
        public Staff()
        {
            this.Creators = new List<Activity>();
            this.Activators = new List<Activity>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name_TH { get; set; }
        public string Name_EN { get; set; }
        public int MajorID { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Phone { get; set; }
        public int PositionID { get; set; }
        public string Room { get; set; }
        public ActiveStatus Active { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public Major Major { get; set; }
        public Position Position { get; set; }

        // public virtual List<Project_Staff> ProjectStaff { get; set; }
        public virtual List<Activity> Creators { get; set; }
        public virtual List<Activity> Activators { get; set; }
    }
}

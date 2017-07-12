using eTracking.Model;
using eTracking.Model.Enum;
using System;

namespace eTracking.Web.ViewModels
{
    public class StaffViewModel
    {
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
    }
}

using eTracking.Model.Enum;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;

namespace eTracking.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public ActiveStatus Active { get; set; }
    //    public int StaffID { get; set; }
    //    public Staff Staff { get; set; }
    }
}

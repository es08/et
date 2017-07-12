using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace eTracking.Identity
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole(string roleName) : base(roleName)
        {
        }
        public ApplicationRole() : base()
        {
        }

        public string Description { get; set; }
    }
}

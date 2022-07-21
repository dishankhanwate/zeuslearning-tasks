using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class User
    {
        public User()
        {
            JobRoleJobRoles = new HashSet<Jobrole>();
            JobRoles = new HashSet<Jobrole>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNo { get; set; } = null!;
        public string ResumeUrl { get; set; } = null!;
        public string? PortfolioUrl { get; set; }
        public string? ReferredBy { get; set; }
        public sbyte? IsReceivingUpdates { get; set; }

        public virtual ICollection<Jobrole> JobRoleJobRoles { get; set; }
        public virtual ICollection<Jobrole> JobRoles { get; set; }
    }
}

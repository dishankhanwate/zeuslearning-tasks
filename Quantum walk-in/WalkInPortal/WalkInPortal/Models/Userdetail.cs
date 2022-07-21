using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Userdetail
    {
        public Userdetail()
        {
            Educationalqualifications = new HashSet<Educationalqualification>();
            Professionalqualifications = new HashSet<Professionalqualification>();
            Userwalkinapplications = new HashSet<Userwalkinapplication>();
            JobRoles = new HashSet<Jobrole>();
        }

        public int UserDetailId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string PhoneNo { get; set; } = null!;
        public string ResumeUrl { get; set; } = null!;
        public string? PortfolioUrl { get; set; }
        public string? ReferredBy { get; set; }
        public bool? IsReceivingUpdates { get; set; }

        public virtual ICollection<Educationalqualification> Educationalqualifications { get; set; }
        public virtual ICollection<Professionalqualification> Professionalqualifications { get; set; }
        public virtual ICollection<Userwalkinapplication> Userwalkinapplications { get; set; }

        public virtual ICollection<Jobrole> JobRoles { get; set; }
    }
}

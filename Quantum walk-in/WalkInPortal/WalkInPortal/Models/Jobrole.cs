using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Jobrole
    {
        public Jobrole()
        {
            UserDetails = new HashSet<Userdetail>();
            Userwalkinapplications = new HashSet<Userwalkinapplication>();
            WalkIns = new HashSet<Walkin>();
        }

        public int JobRoleId { get; set; }
        public string Title { get; set; } = null!;
        public string JobDetails { get; set; } = null!;

        public virtual ICollection<Userdetail> UserDetails { get; set; }
        public virtual ICollection<Userwalkinapplication> Userwalkinapplications { get; set; }
        public virtual ICollection<Walkin> WalkIns { get; set; }
    }
}

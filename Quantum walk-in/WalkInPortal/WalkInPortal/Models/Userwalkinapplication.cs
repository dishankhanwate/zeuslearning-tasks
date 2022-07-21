using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Userwalkinapplication
    {
        public Userwalkinapplication()
        {
            Postapplicationguidelines = new HashSet<Postapplicationguideline>();
            JobRoles = new HashSet<Jobrole>();
            TimeSlots = new HashSet<Timeslot>();
        }

        public int UserDetailId { get; set; }
        public int WalkInId { get; set; }

        public virtual Userdetail UserDetail { get; set; } = null!;
        public virtual Walkin WalkIn { get; set; } = null!;
        public virtual ICollection<Postapplicationguideline> Postapplicationguidelines { get; set; }

        public virtual ICollection<Jobrole> JobRoles { get; set; }
        public virtual ICollection<Timeslot> TimeSlots { get; set; }
    }
}

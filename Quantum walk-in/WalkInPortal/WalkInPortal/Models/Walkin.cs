using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Walkin
    {
        public Walkin()
        {
            Prerequisites = new HashSet<Prerequisite>();
            Userwalkinapplications = new HashSet<Userwalkinapplication>();
            JobRoles = new HashSet<Jobrole>();
            TimeSlots = new HashSet<Timeslot>();
        }

        public int WalkInId { get; set; }
        public string Title { get; set; } = null!;
        public DateOnly FromDate { get; set; }
        public DateOnly ToDate { get; set; }
        public string Location { get; set; } = null!;
        public DateOnly ExpiryDate { get; set; }
        public string? InternshipInfo { get; set; }

        public virtual ICollection<Prerequisite> Prerequisites { get; set; }
        public virtual ICollection<Userwalkinapplication> Userwalkinapplications { get; set; }

        public virtual ICollection<Jobrole> JobRoles { get; set; }
        public virtual ICollection<Timeslot> TimeSlots { get; set; }
    }
}

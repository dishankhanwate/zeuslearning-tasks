using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Timeslot
    {
        public Timeslot()
        {
            Userwalkinapplications = new HashSet<Userwalkinapplication>();
            WalkIns = new HashSet<Walkin>();
        }

        public int TimeSlotId { get; set; }
        public DateOnly FromTime { get; set; }
        public DateOnly ToTime { get; set; }

        public virtual ICollection<Userwalkinapplication> Userwalkinapplications { get; set; }
        public virtual ICollection<Walkin> WalkIns { get; set; }
    }
}

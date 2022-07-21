using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Walkintimeslotmap
    {
        public int WalkInId { get; set; }
        public int TimeSlotId { get; set; }

        public virtual Timeslot TimeSlot { get; set; } = null!;
    }
}

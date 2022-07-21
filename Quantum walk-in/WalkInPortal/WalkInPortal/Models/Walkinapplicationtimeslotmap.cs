using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Walkinapplicationtimeslotmap
    {
        public int WalkInApplicationId { get; set; }
        public int TimeSlotId { get; set; }

        public virtual Timeslot TimeSlot { get; set; } = null!;
    }
}

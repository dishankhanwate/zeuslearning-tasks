using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class TimeslotHasWalkin
    {
        public int TimeSlotTimeSlotId { get; set; }
        public int WalkInWalkInId { get; set; }

        public virtual Timeslot TimeSlotTimeSlot { get; set; } = null!;
    }
}

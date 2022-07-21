using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Prerequisite
    {
        public int PreRequisiteId { get; set; }
        public string Fields { get; set; } = null!;
        public int WalkInId { get; set; }

        public virtual Walkin WalkIn { get; set; } = null!;
    }
}

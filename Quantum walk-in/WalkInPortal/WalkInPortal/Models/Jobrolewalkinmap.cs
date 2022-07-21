using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Jobrolewalkinmap
    {
        public int JobRoleId { get; set; }
        public int WalkInId { get; set; }

        public virtual Jobrole JobRole { get; set; } = null!;
    }
}

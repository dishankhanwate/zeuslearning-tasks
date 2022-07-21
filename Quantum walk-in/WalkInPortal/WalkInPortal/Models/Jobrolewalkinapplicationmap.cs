using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Jobrolewalkinapplicationmap
    {
        public int JobRoleId { get; set; }
        public int WalkInApplicationId { get; set; }

        public virtual Jobrole JobRole { get; set; } = null!;
    }
}

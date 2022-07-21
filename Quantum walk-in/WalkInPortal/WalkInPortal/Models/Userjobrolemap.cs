using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Userjobrolemap
    {
        public int UserId { get; set; }
        public int JobRoleId { get; set; }

        public virtual Jobrole JobRole { get; set; } = null!;
    }
}

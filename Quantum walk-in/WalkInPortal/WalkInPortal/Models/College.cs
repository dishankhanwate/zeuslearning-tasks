using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class College
    {
        public College()
        {
            Educationalqualifications = new HashSet<Educationalqualification>();
        }

        public int CollegeId { get; set; }
        public string? CollegeName { get; set; }
        public int QualificationStreamId { get; set; }

        public virtual Qualificationstream QualificationStream { get; set; } = null!;
        public virtual ICollection<Educationalqualification> Educationalqualifications { get; set; }
    }
}

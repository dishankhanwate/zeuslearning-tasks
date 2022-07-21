using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Qualificationstream
    {
        public Qualificationstream()
        {
            Colleges = new HashSet<College>();
            Educationalqualifications = new HashSet<Educationalqualification>();
        }

        public int QualificationStreamId { get; set; }
        public string QualificationStreamName { get; set; } = null!;
        public int QualificationId { get; set; }

        public virtual Qualification Qualification { get; set; } = null!;
        public virtual ICollection<College> Colleges { get; set; }
        public virtual ICollection<Educationalqualification> Educationalqualifications { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Qualification
    {
        public Qualification()
        {
            Educationalqualifications = new HashSet<Educationalqualification>();
            Qualificationstreams = new HashSet<Qualificationstream>();
        }

        public int QualificationId { get; set; }
        public string Field { get; set; } = null!;

        public virtual ICollection<Educationalqualification> Educationalqualifications { get; set; }
        public virtual ICollection<Qualificationstream> Qualificationstreams { get; set; }
    }
}

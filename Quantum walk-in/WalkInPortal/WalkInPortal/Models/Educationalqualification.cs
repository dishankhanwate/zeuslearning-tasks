using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Educationalqualification
    {
        public int EducatiionalQualificationsId { get; set; }
        public float AggregatePercentage { get; set; }
        public int YearOfPassing { get; set; }
        public string? UnknownCollegeName { get; set; }
        public string CollegeLocation { get; set; } = null!;
        public int UserDetailId { get; set; }
        public int QualificationId { get; set; }
        public int QualificationStreamId { get; set; }
        public int CollegeId { get; set; }

        public virtual College College { get; set; } = null!;
        public virtual Qualification Qualification { get; set; } = null!;
        public virtual Qualificationstream QualificationStream { get; set; } = null!;
        public virtual Userdetail UserDetail { get; set; } = null!;
    }
}

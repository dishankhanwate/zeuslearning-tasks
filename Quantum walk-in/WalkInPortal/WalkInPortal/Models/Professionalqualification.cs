using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Professionalqualification
    {
        public Professionalqualification()
        {
            Expertiseteches = new HashSet<Expertisetech>();
            Familiarteches = new HashSet<Familiartech>();
        }

        public int ProfessionalQualificationId { get; set; }
        public sbyte IsFresher { get; set; }
        public int? YearsOfExperience { get; set; }
        public int? Ctc { get; set; }
        public int? ExpectedCtc { get; set; }
        public bool? HasAppearedTest { get; set; }
        public string? RoleApplied { get; set; }
        public int UserDetailId { get; set; }

        public virtual Userdetail UserDetail { get; set; } = null!;
        public virtual ICollection<Expertisetech> Expertiseteches { get; set; }
        public virtual ICollection<Familiartech> Familiarteches { get; set; }
    }
}

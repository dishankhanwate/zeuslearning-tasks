using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Professionalqualification1
    {
        public int ProfessionalQualificationsId { get; set; }
        public sbyte IsFresher { get; set; }
        public int YearsOfExperience { get; set; }
        public int Ctc { get; set; }
        public int ExpectedCtc { get; set; }
        public sbyte HasAppearedTest { get; set; }
        public string? RoleApplied { get; set; }
    }
}

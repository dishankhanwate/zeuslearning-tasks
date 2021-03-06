using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Familiartech
    {
        public int FamiliarTechId { get; set; }
        public string? Name { get; set; }
        public int ProfessionalQualificationId { get; set; }
        public int UserDetailId { get; set; }

        public virtual Professionalqualification Professionalqualification { get; set; } = null!;
    }
}

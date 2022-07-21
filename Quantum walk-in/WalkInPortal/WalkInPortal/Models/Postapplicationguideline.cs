using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Postapplicationguideline
    {
        public int PostApplicationGuidelinesId { get; set; }
        public string Fields { get; set; } = null!;
        public int UserDetailId { get; set; }
        public int WalkInId { get; set; }

        public virtual Userwalkinapplication Userwalkinapplication { get; set; } = null!;
    }
}

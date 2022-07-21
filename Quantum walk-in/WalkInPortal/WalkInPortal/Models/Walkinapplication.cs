using System;
using System.Collections.Generic;

namespace WalkInPortal.Models
{
    public partial class Walkinapplication
    {
        public int WalkInApplicationId { get; set; }
        public int WalkInId { get; set; }
        public int UserId { get; set; }
        public int PostApplicationGuidelinesId { get; set; }
    }
}

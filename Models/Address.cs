using System;
using System.Collections.Generic;

#nullable disable

namespace MSIT141Site.Models
{
    public partial class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string SiteId { get; set; }
        public string Road { get; set; }
    }
}

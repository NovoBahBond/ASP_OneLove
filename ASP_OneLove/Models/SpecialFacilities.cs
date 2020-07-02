using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP_OneLove.Models
{
    public class SpecialFacility
    {
        [Key]
        public int Id { get; set; }
        public Facility Facility { get; set; }
    }
}
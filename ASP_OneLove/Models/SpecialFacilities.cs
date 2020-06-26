using System.ComponentModel.DataAnnotations;

namespace ASP_OneLove.Models
{
    public class SpecialFacilities
    {
        [Key]
        public int FacilityId { get; set; }
        
        public Facilities Facility { get; set; }
    }
}
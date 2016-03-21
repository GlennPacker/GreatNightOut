using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GNO.Models
{
    public class Venue : BaseEntity
    {
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Venue")]
        [StringLength(50, ErrorMessage = "Name may not be longer than 50 characters")]
        public string Name { get; set; }

        [Display(Name = "Address")]
        public string Address1 { get; set; }

        [Display(Name = " ")]
        public string Address2 { get; set; }

        [Display(Name = "Town")]
        public string Town { get; set; }

        [Display(Name = "Post Code")]
        public string PostCode { get; set; }

        public ICollection<Party> Parties { get; set; }
        public virtual ICollection<PartyImage> PartyImages { get; set; }

        public int TripAdvisorId { get; set;}
        [ForeignKey("TripAdvisorId")]
        public virtual TripAdvisor TripAdvisor { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace GNO.Models
{
    public class TripAdivsorAddress : BaseEntity
    {
        public virtual TripAdvisor TripAdvisor { get; set; }

        public string city { get; set; }
        public string Postalcode { get; set; }
        public string street1 { get; set; }
        public string street2 { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GNO.Models
{
    public class TripAdvisorReview : BaseEntity
    {
        public int TripAdvisorId { get; set; }
        [ForeignKey("TripAdvisorId")]
        public TripAdvisor TripAdvisor { get; set; }
        public DateTime published_date { get; set; }
        public int rating { get; set; }
        public string rating_image_url { get; set; }
        public string text { get; set; }
        public string title { get; set; }
        public string url { get; set; }
    }
}
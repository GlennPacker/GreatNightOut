using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GNO.Models
{
    public class TripAdvisor : BaseEntity
    {
        public int location_id { get; set; }
        public decimal rating { get; set; }
        public string rating_image_url { get; set; }
        public virtual ICollection<TripAdvisorReview> reviews { get; set; }
        public string web_url { get; set; }
        public string write_review { get; set; }
        public string name { get; set; }
        public DateTime LastUpdate { get; set; }
        public int num_reviews { get; set; }
        public int? percent_recommended { get; set; }
        
    }
}

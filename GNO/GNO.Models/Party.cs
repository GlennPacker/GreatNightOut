using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GNO.Models
{
    public class Party : BaseEntity
    {
        [Column(TypeName = "VARCHAR")]
        [Required(ErrorMessage = "Title is required")]
        [StringLength(50, ErrorMessage = "Title may not be longer than 50 characters")]
        public string Title { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime Date { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(1000)]
        [Display(Name = "About the event / night out")]
        [Required(ErrorMessage = "Event Description is required")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Date Added")]
        public DateTime Created { get; set; }

        public int? MeetupEventID { get; set; }
        public DateTime? MeetupLastUpdated { get; set; }

        [UIHint("HourDropDown")]
        [Display(Name = "Time")]
        [Required(ErrorMessage = "Hour is required")]
        public Int32 EventHour { get; set; }

        [UIHint("MinuteDropDown")]
        [Required(ErrorMessage = "Minute is required")]
        [Display(Name = ":")]
        public Int32 EventMin { get; set; }

        [Display(Name = "Event Date")]
        [Required(ErrorMessage = "Date is required")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime EventDate { get; set; }

        public int HostID { get; set; }
        [ForeignKey("HostID")]
        public UserAccount Host { get; set; }

        public int VenueID { get; set; }
        [ForeignKey("VenueID")]
        public Venue Venue { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Reply> Reply { get; set; }
        public virtual ICollection<PartyImage> PartyImages { get; set; }
    }
}
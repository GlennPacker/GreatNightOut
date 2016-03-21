using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GNO.Models
{
    public class Comment: BaseEntity
    {
        public virtual int PartyId { get; set; }
        [ForeignKey("PartyId")]
        public virtual Party Party { get; set; }

        [Display(Name = "Remark")]
        [DataType(DataType.MultilineText)]
        public string Remark { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual UserAccount User { get; set; }

        public DateTime Added { get; set; }
        
    }
}
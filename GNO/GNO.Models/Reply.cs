using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GNO.Models
{
    public class Reply : BaseEntity
    {
        public int UserId { get; set; }      
        [ForeignKey("UserId")]
        public virtual UserAccount Going { get; set; }

        public int PartyId { get; set; }
        [ForeignKey("PartyId")]
        public virtual Party Party { get; set; }
    }
}
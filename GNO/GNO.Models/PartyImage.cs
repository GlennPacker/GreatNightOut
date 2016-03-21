using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GNO.Models
{
    public class PartyImage : BaseEntity
    {
        public ICollection<Image> Images { get; set; }
    }
}

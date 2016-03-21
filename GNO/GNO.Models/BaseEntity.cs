using System.ComponentModel.DataAnnotations;

namespace GNO.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}

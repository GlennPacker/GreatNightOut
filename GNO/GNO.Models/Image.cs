using System.ComponentModel.DataAnnotations;

namespace GNO.Models
{
    public class Image: BaseEntity
    {
        public string DefaultPic { get; set; }
        public byte[] DefaultImg { get; set; }
    }
}

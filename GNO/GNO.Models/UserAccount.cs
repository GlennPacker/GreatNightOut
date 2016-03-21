using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GNO.Models
{
    public class UserAccount : BaseEntity
    {       
        public string Name { get; set; }

        [Display(Name = "Screen / Display Name")]
        public string ScreenName { get; set; }

        [Display(Name = "About Me")]
        [DataType(DataType.MultilineText)]
        public string AboutMe { get; set; }
        
        public string EmailAddress { get; set; } 
       
        [Display(Name="Email Address")]
        public string Correspondance { get; set; }
        
        public virtual Image Image { get; set; }

        [Display(Name = "Contact Tel.")]
        public string Tel { get; set; }

        public int? AuthUserId { get; set; }

        public string Town { get; set; }
        public bool IsAdmin { get; set; }

        public virtual ICollection<Reply> Reply { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual bool UnSubscribe { get; set; }
    }
}
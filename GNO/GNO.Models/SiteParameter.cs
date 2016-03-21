using System;
using System.ComponentModel.DataAnnotations;

namespace GNO.Models
{
    public class SiteParameter : BaseEntity
    {
        public ParameterType ParameterType { get; set;}
        public DateTime SentDate { get; set; }
    }
}
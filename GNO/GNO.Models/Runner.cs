using System;

namespace GNO.Models
{
    public class Runner : BaseEntity
    {
        public RunType RunType { get; set; }
        public DateTime LastRun { get; set; }
    }
}

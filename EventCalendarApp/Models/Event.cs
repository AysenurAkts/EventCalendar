using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EventCalendarApp.Models
{
    public class Event
    {
        [Key]
        public int EventId {get; set;}
        [Column(TypeName ="nvarchar(100)")]
        public string EventTitle { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime EventEndDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib.Models.ZenithSociety
{
    public class Event
    {
        public int EventId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Username { get; set; }
        public DateTime CreationDate { get; set; }
        public Boolean IsActive { get; set; }
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }

        [ForeignKey("Username")]
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}

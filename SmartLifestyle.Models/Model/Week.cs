using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartLifestyle.Models.Model
{
    public class Week
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }

        public int? MondayId { get; set; }
        public Monday Monday { get; set; }

        public int? TuesdayId { get; set; }
        public Tuesday Tuesday { get; set; }

        public int? WednesdayId { get; set; }
        public Wednesday Wednesday { get; set; }

        public int? ThursdayId { get; set; }
        public Thursday Thursday { get; set; }

        public int? FridayId { get; set; }
        public Friday Friday { get; set; }

        public int? SaturdayId { get; set; }
        public Saturday Saturday { get; set; }

        public int? SundayId { get; set; }
        public Sunday Sunday { get; set; }

        public int StartEvent { get; set; }
        public int EndEvent { get; set; }
        public string Month { get; set; }

    }
}

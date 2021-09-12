using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartLifestyle.BusinessLogic.Models
{
    public class WeekDTO
    {
        public MondayDTO monday { get; set; }

        public TuesdayDTO tuesday { get; set; }

        public WednesdayDTO wednesday { get; set; }

        public ThursdayDTO thursday { get; set; }

        public FridayDTO friday { get; set; }

        public SaturdayDTO saturday { get; set; }

        public SundayDTO sunday { get; set; }

        public string startEvent { get; set; }

        public int offset { get; set; }

    }
}

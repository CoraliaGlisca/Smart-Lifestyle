using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.BusinessLogic.Models
{
    public class MockupResponse
    {
        public string Week { get; set; }

        public List<WeekDTO> Days { get; set; } = new List<WeekDTO>();


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.BusinessLogic.Models
{
    public class MealDTO
    {

        public int id { get; set; }
        public string imageType { get; set; }
        public string title { get; set; }
        public int readyInMinutes { get; set; }
        public int servings { get; set; }
        public string sourceUrl { get; set; }
    }
}

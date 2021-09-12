using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartLifestyle.Models.Model
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }

        public int IdAPI { get; set; }

        public string ImageType { get; set; }
        public string Title { get; set; }
        public int ReadyInMinutes { get; set; }
        public int Servings { get; set; }
        public string SourceUrl { get; set; }

        public int? MondayId { get; set; }
        public int? TuesdayId { get; set; }
        public int? WednesdayId { get; set; }
        public int? ThursdayId  { get; set; }
        public int? FridayId   { get; set; }
        public int? SaturdayId { get; set; }
        public int? SundayId   { get; set; }

    }
}

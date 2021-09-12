using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartLifestyle.Models.Model
{
    public class WorkoutPlan
    {
        [Key]
        public int Id { get; set; }

        public double WorkoutId1 { get; set; }
        public double WorkoutId2 { get; set; }
        public double WorkoutId3 { get; set; }
        public double WorkoutId4 { get; set; }
        public double WorkoutId5 { get; set; }
        public double WorkoutId6 { get; set; }

        public string UserId { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartLifestyle.Models.Model
{
    public class Workout
    {
        [Key]
        public double Id { get; set; }

        public string Exercise { get; set; } 

        public string Equipment { get; set; }

        public string ExerciseType { get; set; }
        public string MajorMuscle { get; set; }
        public string MinorMuscle { get; set; }

        public string Image { get; set; }

        public string Notes { get; set; }
        public string Modifications { get; set; }

    }
}

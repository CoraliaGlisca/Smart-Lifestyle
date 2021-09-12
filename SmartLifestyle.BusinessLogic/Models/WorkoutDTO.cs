using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.BusinessLogic.Models
{
    public class WorkoutDTO
    {
        public double id { get; set; }
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

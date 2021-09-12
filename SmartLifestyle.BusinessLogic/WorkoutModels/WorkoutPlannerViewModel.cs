using Microsoft.AspNetCore.Mvc.Rendering;
using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartLifestyle.BusinessLogic.Models
{
    
    public class WorkoutPlannerViewModel
    {
        public int FitnessPlanId { get; set; }

        public int UserId { get; set; }

        public int UserDetailsForWorkoutId { get; set; }

        public int Cardio { get; set; }

        public int Weight { get; set; }

        public int Plyo { get; set; }

        public int Laps { get; set; }
        public int Machine { get; set; }
        public int Band { get; set; }
        public int Bar { get; set; }
        public int BodyWeight { get; set; }
        public int BosuBalll { get; set; }
        public int Dumbbells { get; set; }
        public int Kettlebells { get; set; }
        public int Landmine { get; set; }
        public int Platform { get; set; }
        public int SquatRack { get; set; }
        public int Cable { get; set; }
        public int MedicineBall { get; set; }
        public int Arms { get; set; }
        public int Back { get; set; }
        public int Core { get; set; }
        public int FullBody { get; set; }
        public int Legs { get; set; }

        
    }
}

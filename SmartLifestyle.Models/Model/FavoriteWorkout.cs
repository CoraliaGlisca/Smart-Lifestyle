using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartLifestyle.Models.Model
{
    public class FavoriteWorkout
    {
        [Key]
        public int Id { get; set; }
        public virtual Workout Workout { get; set; }
        public virtual int WorkoutId { get; set; }
        public string UserId { get; set; }
    }
}

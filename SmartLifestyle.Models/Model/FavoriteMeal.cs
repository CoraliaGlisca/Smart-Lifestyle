using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartLifestyle.Models.Model
{
    public class FavoriteMeal
    {
        [Key]
        public int Id { get; set; }
        public virtual Meal Meal { get; set; }
        public int MealId { get; set; }
        public string UserId { get; set; }
    }
}

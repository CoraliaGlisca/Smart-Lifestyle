using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartLifestyle.Models.Model
{
    
    public class UserDetailsForMeal
    { 
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }

        public string? Allergens { get; set; }
        
        [Required]
        public string? Diet { get; set; }      

        public string? ExcludedIngredients { get; set; }

        [Required]
        public int TargetCalories { get; set; }

        

    }
}

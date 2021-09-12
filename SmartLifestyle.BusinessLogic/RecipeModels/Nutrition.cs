using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.BusinessLogic.RecipeModels
{
    public class Nutrition
    {
        public List<Nutrient> nutrients { get; set; }
        public List<Property> properties { get; set; }
        public List<Flavonoid> flavonoids { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public CaloricBreakdown caloricBreakdown { get; set; }
        public WeightPerServing weightPerServing { get; set; }
    }
}

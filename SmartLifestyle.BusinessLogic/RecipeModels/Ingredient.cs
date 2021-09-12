using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.BusinessLogic.RecipeModels
{
    public class Ingredient
    {
        public int id { get; set; }
        public string name { get; set; }
        public double amount { get; set; }
        public string unit { get; set; }
        public List<Nutrient> nutrients { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.BusinessLogic.RecipeModels
{
    public class ExtendedIngredient
    {
        public string aisle { get; set; }
        public double amount { get; set; }
        public string consitency { get; set; }
        public int id { get; set; }
        public string image { get; set; }
        public Measures measures { get; set; }
        public List<string> meta { get; set; }
        public string name { get; set; }
        public string original { get; set; }
        public string originalName { get; set; }
        public string unit { get; set; }
    }
}

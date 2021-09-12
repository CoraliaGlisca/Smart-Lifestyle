using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.BusinessLogic.RecipeModels
{
    public class ProductMatch
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string imageUrl { get; set; }
        public double averageRating { get; set; }
        public double ratingCount { get; set; }
        public double score { get; set; }
        public string link { get; set; }
    }
}

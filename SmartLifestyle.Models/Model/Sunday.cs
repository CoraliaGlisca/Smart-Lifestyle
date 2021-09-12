using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartLifestyle.Models.Model
{
    public class Sunday
    {
        [Key]
        public int Id { get; set; }

        public virtual IList<Meal> Meal { get; set; }

        public int NutrientsId { get; set; }
        public virtual Nutrients Nutrients { get; set; }


    }
}

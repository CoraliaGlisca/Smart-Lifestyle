﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.BusinessLogic.Models
{
    public class FridayDTO
    {
        public IList<MealDTO> meals { get; set; }

        public NutrientsDTO nutrients { get; set; }
    }
}

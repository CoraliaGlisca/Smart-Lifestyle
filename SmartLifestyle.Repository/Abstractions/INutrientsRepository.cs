using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Repository.Abstractions
{
    public interface INutrientsRepository : IRepository<Nutrients>
    {
        public Nutrients GetNutrientsByNutrientId(int id);
    }
}

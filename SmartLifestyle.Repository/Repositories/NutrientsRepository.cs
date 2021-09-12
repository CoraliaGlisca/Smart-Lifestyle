using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class NutrientsRepository : BaseRepository<Nutrients>, INutrientsRepository
    {
        public NutrientsRepository(SmartLDbContext dbContext) : base(dbContext)
        {

        }
        public Nutrients GetNutrientsByNutrientId(int id)
        {
            return dbContext.Nutrients.FirstOrDefault(s => s.Id == id);
        }
    }
}

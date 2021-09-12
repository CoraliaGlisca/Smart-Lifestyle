using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class FridayRepository : BaseRepository<Friday>, IFridayRepository
    {
        public FridayRepository(SmartLDbContext  dbContext) : base(dbContext)
        {

        }
        public Friday GetFridayById(int? id)
        {
            return dbContext.Fridays.SingleOrDefault(s => s.Id == id);
        }
    }
}

using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class SundayRepository : BaseRepository<Sunday>, ISundayRepository
    {
        public SundayRepository(SmartLDbContext dbContext) : base(dbContext)
        {

        }
        public Sunday GetSundayById(int? id)
        {
            return dbContext.Sundays.SingleOrDefault(s => s.Id == id);
        }
    }
}

using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class WednesdayRepository : BaseRepository<Wednesday>, IWednesdayRepository
    {
        public WednesdayRepository(SmartLDbContext dbContext) : base(dbContext)
        {

        }
        public Wednesday GetWednesdayById(int? id)
        {
            return dbContext.Wednesdays.SingleOrDefault(s => s.Id == id);
        }
    }
}

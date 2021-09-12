using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class MondayRepository : BaseRepository<Monday>, IMondayRepository
    {
        public MondayRepository(SmartLDbContext dbContext) : base(dbContext)
        {

        }
        public Monday GetMondayById(int? id)
        {
            return dbContext.Mondays.SingleOrDefault(s => s.Id == id);
        }
    }
}

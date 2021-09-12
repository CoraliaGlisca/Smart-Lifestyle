using SmartLifestyle.Models.Model;
using SmartLifestyle.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartLifestyle.Repository.Repositories
{
    public class UserOffsetRepository : BaseRepository<UserOffset>, IUserOffsetRepository
    {
        public UserOffsetRepository(SmartLDbContext dbContext) : base(dbContext)
        {

        }

        public void AddUserOffset(UserOffset userOffset)
        {
            var item = dbContext.UserOffsets.Any(m => m.UserId == userOffset.UserId);
            if (!item)
            {
                dbContext.UserOffsets.Add(userOffset);
            }
            dbContext.SaveChanges();
        }

        public int GetOffsetByUserId(string userId)
        {
            if (dbContext.UserOffsets.Any(s => s.UserId == userId))
            {
                return dbContext.UserOffsets.FirstOrDefault(s => s.UserId == userId).Offset;
            }
            return 0;
            
        }

        public void SetOffsetToZero(string userId)
        {
            var userOffset = dbContext.UserOffsets.Any(s => s.UserId == userId);
            if(userOffset)
            {
                dbContext.UserOffsets.FirstOrDefault(s => s.UserId == userId).Offset = 0;
            }              
            dbContext.SaveChanges();
        }

        public void UpdateOffset(string userId, int offset)
        {
            var userOffset = dbContext.UserOffsets.FirstOrDefault(s => s.UserId == userId);
            userOffset.Offset = userOffset.Offset + offset;
            dbContext.SaveChanges();
        }
    }
}

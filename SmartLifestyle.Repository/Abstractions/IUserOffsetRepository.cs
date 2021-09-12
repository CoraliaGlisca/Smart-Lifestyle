using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Repository.Abstractions
{
    public interface IUserOffsetRepository : IRepository<UserOffset>
    {
        public void SetOffsetToZero(string userId);
        public void UpdateOffset(string userId, int offset);
        public int  GetOffsetByUserId(string userId);
        public void AddUserOffset(UserOffset userOffset);
    }
}

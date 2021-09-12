using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Repository.Abstractions
{
    public interface ISundayRepository : IRepository<Sunday>
    {
        public Sunday GetSundayById(int? id);
    }
}

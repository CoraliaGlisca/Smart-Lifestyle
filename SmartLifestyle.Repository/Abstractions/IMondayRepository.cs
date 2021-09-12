using SmartLifestyle.Models.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.Repository.Abstractions
{
    public interface IMondayRepository : IRepository<Monday>
    {
        public Monday GetMondayById(int? id);

    }
}

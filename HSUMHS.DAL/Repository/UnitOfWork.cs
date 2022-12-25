using HSUMHS.DAL.Data;
using HSUMHS.DAL.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSUMHS.DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
          
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}

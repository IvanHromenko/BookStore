using BookStore.DataAccess.Repository.IRepository;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository
{
    public class CoverRepository : Repository<Cover>, ICoverRepository
    {
        private ApplicationDbContext _db;
        public CoverRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Cover obj)
        {
            _db.Covers.Update(obj);
        }
    }
}

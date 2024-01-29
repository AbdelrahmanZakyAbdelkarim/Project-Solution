using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using Project.DAL.Data;
using Project.DAL.Models;
using Project.DLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DLL.Repositories
{
    internal class BomRepository : IBomRepository
    {
        private readonly AppDbContext _dbContext;
        public BomRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Add(BOM entity)
        {
            _dbContext.BOMs.Add(entity); 
            return _dbContext.SaveChanges();
        
        }
        public int Update(BOM entity)
        {
            _dbContext.Update(entity);
            return _dbContext.SaveChanges();
        }

        public int Delete(BOM entity)
        {
            _dbContext.Remove(entity);
            return _dbContext.SaveChanges();
        }

        public BOM Get(int id)
            => _dbContext.BOMs.Find(id);
        

        public IEnumerable<BOM> GetAll()
            => _dbContext.BOMs.AsNoTracking().ToList();

        
    }
}

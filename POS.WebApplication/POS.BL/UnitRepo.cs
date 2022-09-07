using Microsoft.EntityFrameworkCore;
using POS.Data;
using POS.IBL;
using POS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BL
{
    public class UnitRepo : IUnitRepo
    {
        private readonly POSDbContext dbContext;
        public UnitRepo(POSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        //Add Unit
        public async Task<int> Create(UnitM t)
        {
            t.CreatedDate = DateTime.Now;
            dbContext.Units.Add(t);
            return await dbContext.SaveChangesAsync();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UnitM>> GetAll()
        {
            return await dbContext
                .Units
                .Where(i => i.IsDeleted == false)
                .ToListAsync();
        }

        public async Task<UnitM> GetById(int id)
        {
            return await dbContext
                .Units
                .Where(i => i.IsDeleted == false && i.UnitId == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> Update(UnitM t)
        {
            throw new NotImplementedException();
        }
    }
}

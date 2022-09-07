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
    public class SizeRepo : ISizeRepo
    {
        private readonly POSDbContext dbContext;
        public SizeRepo(POSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<int> Create(SizeM t)
        {
            t.CreatedDate = DateTime.Now;
            dbContext.Sizes.Add(t);

            return await dbContext.SaveChangesAsync();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SizeM>> GetAll()
        {
            return await dbContext
                .Sizes
                .Where(i => i.IsDeleted == false)
                .ToListAsync();
        }

        public Task<SizeM> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(SizeM t)
        {
            throw new NotImplementedException();
        }
    }
}

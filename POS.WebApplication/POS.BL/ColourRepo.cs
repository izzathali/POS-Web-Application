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
    public class ColourRepo : IColourRepo
    {
        private readonly POSDbContext dbContext;
        public ColourRepo(POSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<int> Create(ColourM t)
        {
            t.CreatedDate = DateTime.Now;
            dbContext.Colours.Add(t);
            return await dbContext.SaveChangesAsync();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ColourM>> GetAll()
        {
            return await dbContext
                .Colours
                .Where(i => i.IsDeleted == false)
                .ToListAsync();
        }

        public Task<ColourM> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(ColourM t)
        {
            throw new NotImplementedException();
        }
    }
}

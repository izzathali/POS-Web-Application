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
    public class SubProductRepo : ISubProductRepo
    {
        private readonly POSDbContext dbContext;
        public SubProductRepo(POSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<int> Create(SubProductM t)
        {
            t.CreatedDate = DateTime.Now;
            dbContext.SubProducts.Add(t);
            return await dbContext.SaveChangesAsync();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SubProductM>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SubProductM> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(SubProductM t)
        {
            throw new NotImplementedException();
        }
    }
}

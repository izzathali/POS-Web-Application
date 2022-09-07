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
    public class BrandRepo : IBrandRepo
    {
        private readonly POSDbContext dbContext;
        public BrandRepo(POSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        //Add Brand
        public async Task<int> Create(BrandM t)
        {
            t.CreatedDate = DateTime.Now;
            dbContext.Brands.Add(t);
            return await dbContext.SaveChangesAsync();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BrandM>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<BrandM> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(BrandM t)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class ProductRepo : IProductRepo
    {
        private readonly POSDbContext dbContext;
        public ProductRepo(POSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> Create(ProductM t)
        {
            t.CreatedDate = DateTime.Now;
            dbContext.Products.Add(t);
            return await dbContext.SaveChangesAsync();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductM>> GetAll()
        {
            return await dbContext
                .Products
                .Include(i => i.category)
                .Include(i => i.unit)
                .Include(i => i.brand)
                .Include(i => i.subproducts)
                .Where(i => i.IsDeleted == false)
                .ToListAsync();
        }

        public Task<ProductM> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(ProductM t)
        {
            throw new NotImplementedException();
        }
    }
}

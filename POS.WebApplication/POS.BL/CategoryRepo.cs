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
    public class CategoryRepo : ICategoryRepo
    {
        private readonly POSDbContext dbContext;
        public CategoryRepo(POSDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        //Create Category
        public async Task<int> Create(CategoryM t)
        {
            dbContext.Categories.Add(t);
            return await dbContext.SaveChangesAsync();
        }
        //Delete Category
        public async Task<int> Delete(int id)
        {
            CategoryM cat = await GetById(id);

            if (cat != null)
            {
                cat.IsDeleted = true;
                dbContext.Categories.Update(cat);
            }

            return await dbContext.SaveChangesAsync();
        }
        //Get All Category
        public async Task<IEnumerable<CategoryM>> GetAll()
        {
            return await dbContext
                .Categories
                .Where(i => i.IsDeleted == false)
                .ToListAsync();
        }
        //Get Category By Id
        public async Task<CategoryM> GetById(int id)
        {
            return await dbContext
                .Categories
                .Where(i => i.IsDeleted == false && i.CategoryId == id)
                .FirstOrDefaultAsync();
        }
        //Update category
        public async Task<int> Update(CategoryM t)
        {
            dbContext.Categories.Update(t);
            return await dbContext.SaveChangesAsync();
        }
    }
}

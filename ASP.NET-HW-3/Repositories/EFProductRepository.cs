using ASP.NET_HW_3.Data;
using ASP.NET_HW_3.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_HW_3.Repositories
{
	public class EFProductRepository : IProductRepository
	{
		private readonly ProductDbContext _context;

		public EFProductRepository(ProductDbContext context)
		{
			_context = context;
		}

		public async Task AddAsync(Product product)
		{
			await _context.Products.AddAsync(product);
			await _context.SaveChangesAsync();
		}

		public async Task<List<Product>> GetAllAsync()
		{

			return await _context.Products.ToListAsync();

		}

		public async Task DeleteAsync(int ID)
		{
			var delete = await _context.Products.SingleOrDefaultAsync(p=>p.Id== ID);

			_context.Products.Remove(delete);	

			await _context.SaveChangesAsync();
		}


		public async Task UpdateAsync(Product product)
		{
			_context.Products.Update(product);
			await _context.SaveChangesAsync();
		}

		public async Task<Product> GetByIdAsync(int ID)
		{
			return await _context.Products.SingleOrDefaultAsync(p => p.Id == ID);
		}
	}
}

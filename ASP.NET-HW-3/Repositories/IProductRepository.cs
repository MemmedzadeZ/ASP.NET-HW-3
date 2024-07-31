using ASP.NET_HW_3.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP.NET_HW_3.Repositories
{
	public interface IProductRepository
	{
		Task<List<Product>> GetAllAsync();
		Task AddAsync(Product product);
		Task UpdateAsync(Product product);
		Task DeleteAsync(int id);
		Task<Product> GetByIdAsync(int ID);
	}
}

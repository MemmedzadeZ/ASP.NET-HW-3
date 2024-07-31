using ASP.NET_HW_3.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP.NET_HW_3.Services
{
	public interface IProductServices
	{
		Task<List<Product>> GetAllAsync1();
		Task AddAsync(Product product);
		Task UpdateAsync(Product product);
		Task DeleteAsync(int id);
		Task<Product> GetByIdAsync(int ID);

	}
}

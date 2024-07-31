using ASP.NET_HW_3.Entities;
using ASP.NET_HW_3.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP.NET_HW_3.Services
{
	public class ProductServices : IProductServices
	{

		private readonly IProductRepository _productRepository;

		public ProductServices(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		public async Task AddAsync(Product product)
		{
			await _productRepository.AddAsync(product);
		}

		public async Task DeleteAsync(int id)
		{
			 await _productRepository.DeleteAsync(id);
		}

		public async Task<List<Product>> GetAllAsync1()
		{
			return await _productRepository.GetAllAsync();
		}

	
		public async Task<Product> GetByIdAsync(int ID)
		{
			return await _productRepository.GetByIdAsync(ID);
		}

		public async Task UpdateAsync(Product product)
		{
			await _productRepository.UpdateAsync(product);
		}
	}
}

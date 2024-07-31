using ASP.NET_HW_3.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_HW_3.Data
{
	public class ProductDbContext:DbContext
	{
		public ProductDbContext(DbContextOptions<ProductDbContext> options)
			:base(options) 
		{


		
		}
		public DbSet<Product> Products { get; set; }
		
	}
}

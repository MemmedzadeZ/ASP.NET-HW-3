using ASP.NET_HW_3.Models;
using ASP.NET_HW_3.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ASP.NET_HW_3.Controllers
{
	public class ProductController : Controller
	{

		private readonly IProductServices _services;

		public ProductController(IProductServices services)
		{
			_services = services;
		}


		[HttpGet]
		public async Task<IActionResult> Index()
		{

			var vm = new ProductListViewModel
			{
				Products = await _services.GetAllAsync1()
			};


			return View(vm);
		}


		[HttpGet]
		public IActionResult Add()
		{
			var vm = new ProductViewModel
			{
				Product = new Entities.Product()
			};

			return View(vm);
		}


		[HttpPost]

		public async Task<IActionResult> Add(ProductViewModel vm)
		{

			await _services.AddAsync(vm.Product);


			return RedirectToAction(nameof(Index));

		}

		[HttpGet]

		public async Task<IActionResult> Delete(int ID)
		{
			await _services.DeleteAsync(ID);
			return RedirectToAction(nameof(Index));
		}

		[HttpGet]
		public async Task<IActionResult> Update(int id)
		{
			var vm = new ProductViewModel
			{
				Product = await _services.GetByIdAsync(id)
			};
			return View(vm);
		}

		[HttpPost]


		public async Task<IActionResult> Update(ProductViewModel vm,int id)
		{
			vm.Product.Id = id;
			await _services.UpdateAsync(vm.Product);
			return RedirectToAction(nameof(Index));
		}

	}
}


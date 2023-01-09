using xe_test.Implementation;
using xe_test.Models;
using xe_test.Repository.Interfaces;

namespace xe_test.Repository
{
	public class InMemoryProductRepository : IProductRepository
	{
		private static readonly Dictionary<string, Product> products = new Dictionary<string, Product>
		{
			{ "A", new Product("Apple", "A", 1.25m, new VolumeDiscountStrategy() { VolumePrice = 3m, VolumeQuantity = 3 }) },
			{ "B", new Product("Banana", "B", 4.25m, new NoDiscountStrategy()) },
			{ "C", new Product("Carrot", "C", 1m, new VolumeDiscountStrategy() { VolumePrice = 5m, VolumeQuantity = 6 }) },
			{ "D", new Product("Dragon Fruit", "D", 0.75m,  new NoDiscountStrategy()) }
		};

		public Product GetByCode(string code)
		{
			if (products.TryGetValue(code, out var product))
			{
				return product;
			}
			else
			{
				throw new ArgumentException($"Invalid product code: {code}");
			}
		}
	}
}

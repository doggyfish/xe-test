using xe_test.Interfaces;
using xe_test.Repository.Interfaces;

namespace xe_test.Implementation
{
	public sealed class PointOfSaleTerminal : TerminalBase, ITerminal
	{
		private readonly IProductRepository _productRepository;
		private readonly Dictionary<string, int> cart;

		public PointOfSaleTerminal(IProductRepository productRepository)
		{
			_productRepository = productRepository;
			cart = new Dictionary<string, int>();
		}

		public void SetPricing()
		{
		}

		public void ScanProduct(string code)
		{
			// Look up the product details from the product repository
			if (cart.ContainsKey(code))
			{
				cart[code]++;
			}
			else
			{
				
				cart[code] = 1;
			}
		}

		public decimal CalculateTotal()
		{
			decimal totalPrice = 0;
			foreach (var (code, quantity) in cart)
			{
				var product = _productRepository.GetByCode(code);
				totalPrice += product.DiscountStrategy.CalculateDiscount(product.UnitPrice, quantity);
			}
			return totalPrice;
		}
	}
}

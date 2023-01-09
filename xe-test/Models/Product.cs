using xe_test.Implementation;
using xe_test.Interfaces;

namespace xe_test.Models
{
	public class Product
	{
		public string Name { get; private set; }
		public string Code { get; private set; }
		public decimal UnitPrice { get; private set; }
		public IDiscountStrategy DiscountStrategy { get; private set; }

		public Product(string name, string code, decimal price, IDiscountStrategy discountStrategy)
		{
			Name = name;
			Code = code;
			UnitPrice = price;
			DiscountStrategy = discountStrategy ?? new NoDiscountStrategy();
		}
	}
}

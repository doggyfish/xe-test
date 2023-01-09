using xe_test.Interfaces;

namespace xe_test.Implementation
{
	public sealed class NoDiscountStrategy : DiscountStrategyBase, IDiscountStrategy
	{
		public decimal CalculateDiscount(decimal unitPrice, int quantity)
		{
			return unitPrice * quantity;
		}
	}
}

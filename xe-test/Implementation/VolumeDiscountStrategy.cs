using xe_test.Interfaces;

namespace xe_test.Implementation
{
	public sealed class VolumeDiscountStrategy : DiscountStrategyBase, IDiscountStrategy
    {
		public decimal CalculateDiscount(decimal unitPrice, int quantity)
		{
			if (VolumePrice.HasValue && VolumeQuantity.HasValue)
			{
				// Calculate the volume price for the product
				decimal totalVolumePrice = VolumePrice.Value * (quantity / VolumeQuantity.Value);
				// Calculate the price for the remaining units
				decimal totalUnitPrice = unitPrice * (quantity % VolumeQuantity.Value);
				return totalVolumePrice + totalUnitPrice;
			}
			else
			{
				return unitPrice * quantity;
			}
		}
	}
}

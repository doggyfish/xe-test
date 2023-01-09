namespace xe_test.Interfaces
{
	public interface IDiscountStrategy
	{
		decimal CalculateDiscount(decimal unitPrice, int quantity);
	}
}

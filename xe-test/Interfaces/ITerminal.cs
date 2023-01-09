namespace xe_test.Interfaces
{
	public interface ITerminal
	{
		void SetPricing();
		void ScanProduct(string code);
		decimal CalculateTotal();
	}
}

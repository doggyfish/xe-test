using xe_test.Implementation;
using xe_test.Interfaces;
using xe_test.Repository;
using xe_test.Repository.Interfaces;
using xe_test.ServiceFactory;

namespace xe_test_nunit
{
	public class PointOfSaleTerminalTest
	{
		private ITerminal terminal;

		[SetUp]
		public void Setup()
		{
			var repository = ServiceProviderFactory.Resolve<IProductRepository>();
			terminal = new PointOfSaleTerminal(repository);
		}

		[Test]
		public void GetTotal_EmptyCart_ReturnsZero()
		{
			// Act
			var total = terminal.CalculateTotal();

			// Assert
			Assert.That(total, Is.EqualTo(0));
		}

		[TestCase("A", 1.25)]
		[TestCase("B", 4.25)]
		[TestCase("C", 1)]
		[TestCase("D", 0.75)]
		[TestCase("A,B,C,D", 7.25)]
		[TestCase("A,B,C,D,A,B,A", 13.25)]
		[TestCase("C,C,C,C,C,C,C", 6)]
		public void GetTotal_NonEmptyCart_ReturnsCorrectTotal(string productCodes, decimal expectedTotal)
		{
			// Arrange
			var codes = productCodes.Split(',');
			foreach (var code in codes)
			{
				terminal.ScanProduct(code);
			}

			// Act
			var total = terminal.CalculateTotal();

			// Assert
			Assert.That(total, Is.EqualTo(expectedTotal));
		}
	}
}
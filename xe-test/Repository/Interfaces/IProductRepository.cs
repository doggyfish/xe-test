using xe_test.Models;

namespace xe_test.Repository.Interfaces
{
	public interface IProductRepository
	{
		Product GetByCode(string code);
	}
}

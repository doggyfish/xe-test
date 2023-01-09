using Microsoft.Extensions.DependencyInjection;
using xe_test.Implementation;
using xe_test.Interfaces;
using xe_test.Repository;
using xe_test.Repository.Interfaces;

namespace xe_test.ServiceFactory
{
	public static class ServiceProviderFactory
	{
		private static readonly IServiceProvider _serviceProvider;

		static ServiceProviderFactory()
		{
			var services = new ServiceCollection();

			// Register product repository
			services.AddSingleton<IProductRepository, InMemoryProductRepository>();

			// Register pricing strategies
			services.AddSingleton<IDiscountStrategy, VolumeDiscountStrategy>();
			services.AddSingleton<IDiscountStrategy, NoDiscountStrategy>();

			_serviceProvider = services.BuildServiceProvider();
		}

		public static T Resolve<T>()
		{
			return _serviceProvider.GetRequiredService<T>();
		}
	}
}

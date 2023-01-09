# Dev Notes

## How much time I spent on this exercise

2Hours

## Here's What I Fixed/Refactored/Added (in order of implementation, highest priority first)

Created xe-test class library

Added ReadMe.MD file

Added Product to model folder

Added IDiscountStrategy and ITerminal interfaces folder

Added NoDiscountStrategy, VolumeDiscountStrategy and DiscountStrategyBase to Implemenation folder

Added TerminalBase and PointOfSaleTerminal to Implemenation folder

Installed Microsoft.Extensions.DependencyInjection via NuGet manager

Added ServiceProviderFactory to manage dependency Injection

Added IProductRepository and InMemoryProductRepository implementation

Refactored PointOfSaleTerminal to inject IProductRepository into it

Added NUnit Tests

## Further Improvements I Would Make If I Had More Time (in order of implementation, highest priority first)

implement proper dependency injection, use a proper third-party IOC container like Unity or Autofac

## Here's What I Would Like to Talk About At The Interview
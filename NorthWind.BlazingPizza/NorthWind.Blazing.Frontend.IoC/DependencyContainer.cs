
namespace NorthWind.Blazing.Frontend.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddFrontendServices(this IServiceCollection service)
        {
            service.AddModels();
            service.AddViewModels();
            return service;
        }
    }
}

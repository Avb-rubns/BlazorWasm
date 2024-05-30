namespace NorthWind.BlazingPizza.Frontend.WebApiProxy
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddModels(this IServiceCollection services)
        {
            services.TryAddScoped<IGetSpecialModel, GetSpecialModel>();

            return services;
        }
    }
}

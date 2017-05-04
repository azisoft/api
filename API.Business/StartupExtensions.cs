using API.Business;
using API.Common.Interface;

//namespace Microsoft.Extensions.DependencyInjection
//{
//    public static class StartupExtensions
//    {
//        public static IServiceCollection AddBusiness(this IServiceCollection services)
//        {
//            services.AddDataAccess();
//            return services;
//        }

//    }
//}

namespace StructureMap
{
    public static class StartupExtensions
    {
        public static void AddBusiness(this Container container)
        {
            container.Configure(config =>
            {
                // Register stuff in container, using the StructureMap APIs...
                config.For<IExecute>().Add(new BusinessAccess()).Named("Business");
            });

            container.AddDataAccess();
        }
    }

}

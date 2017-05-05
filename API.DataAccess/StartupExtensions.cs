using API.Common;
using API.Common.Interface;
using API.DataAccess;
using Microsoft.Extensions.Configuration;

namespace StructureMap
{
    public static class StartupExtensions
    {
        public static void AddDataAccess(this Container container)
        {
            var connStringConfigSection = container.GetInstance<IConfigurationSection>(Constants.ConnectionStrings);
            container.Configure(config =>
            {
                // Register stuff in container, using the StructureMap APIs...
                config.For<IExecute>().Add(new DataAccess(container)).Named(Constants.Interface.DataAccess);
                // add providers (lazy load)
                config.For<IExecute>().Add(_ => new API.DataAccess.Providers.SqlEntityFramework.SqlEfProvider(connStringConfigSection)).Named(Constants.Interface.SqlEfProvider);
            });
        }
    }

}

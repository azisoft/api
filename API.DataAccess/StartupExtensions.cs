using API.Common;
using API.Common.Interface;
using API.DataAccess;
using API.DataAccess.Providers;

namespace StructureMap
{
    public static class StartupExtensions
    {
        public static void AddDataAccess(this Container container)
        {
            container.Configure(config =>
            {
                // Register stuff in container, using the StructureMap APIs...
                config.For<IExecute>().Add(new DataAccess(container)).Named(Constants.Interface.DataAccess);
                config.For<IExecute>().Add(new SqlEfProvider()).Named(Constants.Interface.SqlEfProvider);
            });
        }
    }

}

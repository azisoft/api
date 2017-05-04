using API.Common.Interface;
using API.DataAccess;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructureMap
{
    public static class StartupExtensions
    {
        public static void AddDataAccess(this Container container)
        {
            container.Configure(config =>
            {
                // Register stuff in container, using the StructureMap APIs...
                config.For<IExecute>().Add(new DataAccess()).Named("DataAccess");
            });
        }
    }

}

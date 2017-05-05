using API.Common.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using API.Common.Model;
using API.Models;
using Microsoft.Extensions.Configuration;
using API.Common;
using API.DataAccess.Providers.SqlEntityFramework.Contexts;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace API.DataAccess.Providers.SqlEntityFramework
{
    public class SqlEfProvider : IExecute
    {
        private string _connString;
        public SqlEfProvider(IConfigurationSection connStringConfigSection) { _connString = connStringConfigSection[Constants.SqlEfProvider.TestConnectinoString]; }

        public R Execute<R, P>(KeyBase key)
            where R : ModelBase
            where P : KeyBase
        {
            switch (key.Key) {
                case Constants.DataAccessKey.NewData:
                    {
                        using (var context = new TestContext(_connString))
                        {
                            var newData = context.NewDatas.Include(n => n.Lis).FirstOrDefault();
                            return new NewModel()
                            {
                                Title = newData.Title,
                                H2 = newData.H2,
                                Lis = newData.Lis.Select(l => l.LisItem).ToArray()
                            } as R;
                        }
                    }
                default:
                    return null;
                    //{
                    //    Title = "Angular Seed is a starter project that implements best practices in coding, building and testing Angular apps.",
                    //    H2 = "<h2>Gezukam draga - from service</h2>",
                    //    Lis = new[] {
                    //        "Ready to go, statically typed build system using Gulp for working with TypeScript.",
                    //        "Production and development builds.",
                    //        "Sample unit tests with Jasmine and Karma including code coverage via Istanbul.",
                    //        "End-to-end tests with Protractor.",
                    //        "Development server with live reload.",
                    //        "TypeScript definition management using Types.",
                    //        "Basic Service Worker, which implements \"Cache then network strategy\"."
                    //    }
                    //} as R;
            }
        }
    }
}

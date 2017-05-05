using API.Common.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using API.Common.Model;
using API.Models;

namespace API.DataAccess.Providers
{
    public class SqlEfProvider : IExecute
    {
        public R Execute<R, P>(KeyBase key)
            where R : ModelBase
            where P : KeyBase
        {
            return new NewModel()
            {
                Title = "Angular Seed is a starter project that implements best practices in coding, building and testing Angular apps.",
                H2 = "<h2>Gezukam draga - from service</h2>",
                Lis = new[] {
                    "Ready to go, statically typed build system using Gulp for working with TypeScript.",
                    "Production and development builds.",
                    "Sample unit tests with Jasmine and Karma including code coverage via Istanbul.",
                    "End-to-end tests with Protractor.",
                    "Development server with live reload.",
                    "TypeScript definition management using Types.",
                    "Basic Service Worker, which implements \"Cache then network strategy\"."
                }
            } as R;
        }
    }
}

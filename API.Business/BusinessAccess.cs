using System;
using System.Collections.Generic;
using API.Common.Interface;
using API.Common.Model;
using API.Models;
using StructureMap;
using API.Common;

namespace API.Business
{
    public class BusinessAccess : IExecute
    {
        private IExecute _dataAccess;
        public BusinessAccess(IContainer injectedContainer)
        {
            _dataAccess = injectedContainer.GetInstance<IExecute>(Constants.Interface.DataAccess);
        }

        public R Execute<R, P>(KeyBase key)
            where R : ModelBase
            where P : KeyBase
        {
            return _dataAccess.Execute<R, P>(key);
        }
    }
}

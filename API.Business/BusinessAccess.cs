using System;
using System.Collections.Generic;
using API.Common.Interface;
using API.Common.Interface.Model;

namespace API.Business
{
    public class BusinessAccess : IExecute
    {
        public ModelBase Execute<R, P>(KeyBase key)
            where R : ModelBase
            where P : KeyBase
        {
            throw new NotImplementedException();
        }
    }
}

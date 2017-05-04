using API.Common.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using API.Common.Interface.Model;

namespace API.DataAccess
{
    public class DataAccess : IExecute
    {
        public ModelBase Execute<R, P>(KeyBase key)
            where R : ModelBase
            where P : KeyBase
        {
            throw new NotImplementedException();
        }
    }
}

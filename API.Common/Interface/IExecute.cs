using API.Common.Interface.Model;
using System;

namespace API.Common.Interface
{
    public interface IExecute
    {
        ModelBase Execute<R,P>(KeyBase key) where R: ModelBase where P : KeyBase;
    }
}

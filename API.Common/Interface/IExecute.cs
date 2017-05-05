using API.Common.Model;
using System;

namespace API.Common.Interface
{
    public interface IExecute
    {
        R Execute<R,P>(KeyBase key) where R: ModelBase where P : KeyBase;
    }
}

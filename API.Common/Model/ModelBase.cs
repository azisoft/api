using System;
using static API.Common.Constants;

namespace API.Common.Model
{
    public class ModelBase
    {
        
    }

    public class KeyBase
    {
        public KeyBase(DataAccessKey key) { Key = key; }
        public DataAccessKey Key { get; private set; }
    }
}

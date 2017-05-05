using API.Common.Interface;
using System.Collections.Generic;
using API.Common.Model;
using StructureMap;
using API.Models;
using System.IO;
using API.Common;
using Newtonsoft.Json;
using System.Reflection;

namespace API.DataAccess
{
    public class DataAccess : IExecute
    {
        private IContainer _diContainer;
        private Dictionary<string, string> _map;

        public DataAccess(IContainer container)
        {
            _diContainer = container;
            var sJson = File.ReadAllText(Constants.DataAccess.ProviderConfigFile);
            _map = JsonConvert.DeserializeObject<Dictionary<string, string>>(sJson);
        }

        public R Execute<R, P>(KeyBase key)
            where R : ModelBase
            where P : KeyBase
        {
            var diKey = _map[key.Key.ToString()];
            var provider = _diContainer.GetInstance<IExecute>(diKey);
            return provider.Execute<R, P>(key);
        }
    }
}

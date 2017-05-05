using System;
using System.Collections.Generic;
using System.Text;

namespace API.Common
{
    public static class Constants
    {
        public static class Interface
        {
            public const string Business = "Business";
            public const string DataAccess = "DataAccess";
            public const string SqlEfProvider = "SqlEfProvider";
        }

        public static class DataAccess
        {
            public const string ProviderConfigFile = "ProviderConfig.json";
        }

        public enum DataAccessKey
        {
            NewData
        }
    }

}

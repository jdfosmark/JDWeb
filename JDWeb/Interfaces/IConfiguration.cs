using System;

namespace JDWeb.Interfaces
{
    public interface IConfiguration
    {
        object GetConfigurationSetting(Type expectedType, string key);
    }
}

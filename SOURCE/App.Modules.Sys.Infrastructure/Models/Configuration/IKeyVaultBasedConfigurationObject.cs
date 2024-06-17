using App.Modules.Sys.Substrate.tmp.Models.Configuration;

namespace App.Modules.Sys.Substrate.Models.ConfigurationSettings
{
    /// <summary>
    /// Contract for objects that will be passed through the 
    /// KeyVault based Config Factory
    /// </summary>
    public interface IKeyVaultBasedConfigurationObject : IConfigurationObject
    {
    }
}

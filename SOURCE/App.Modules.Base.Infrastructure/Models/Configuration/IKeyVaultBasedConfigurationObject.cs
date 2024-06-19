﻿using App.Modules.Base.Substrate.Models.Configuration;

namespace App.Modules.Base.Substrate.Models.ConfigurationSettings
{
    /// <summary>
    /// Contract for objects that will be passed through the 
    /// KeyVault based Config Factory
    /// </summary>
    public interface IKeyVaultBasedConfigurationObject : IConfigurationObject
    {
    }
}

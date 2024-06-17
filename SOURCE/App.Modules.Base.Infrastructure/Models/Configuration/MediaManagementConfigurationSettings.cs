﻿namespace App.Modules.Base.Substrate.Models.ConfigurationSettings
{
    using App.Modules.Base.Substrate.Models.Configuration;
    using App.Modules.Base.Substrate.tmp.Attributes;
    using App.Modules.Base.Substrate.tmp.Constants;

    /// <summary>
    /// A Configuration settings package to use when configuring Media Management
    /// </summary>
    public class MediaManagementConfigurationSettings: IHostSettingsBasedConfigurationObject
    {
        private string? _hashType;

        /// <summary>
        /// THe Hash type to use when making the hash
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(ConfigurationKeys.AppCoreMediaHashType)]
        public string HashType
        {
            get { return this._hashType?? "SHA-256"; }
            set { this._hashType = value; }
        }
    }
}
using App.Modules.Base.Substrate.tmp.Attributes;
using App.Modules.Base.Substrate.tmp.Constants;

namespace App.Modules.Base.Substrate.Models.ConfigurationSettings
{
    /// <summary>
    /// TODO: Better documentation
    /// </summary>
    public class DemoConfigurationSettings : IHostSettingsBasedConfigurationObject
    {
        /// <summary>
        /// TODO: Better documentation
        /// </summary>
        [ConfigurationSettingSource(ConfigurationSettingSource.SourceType.AppSetting)]
        [Alias(ConfigurationKeys.AppCoreDemoMode)]
        public bool DemoMode
        {
            get; set;
        }
    }
}

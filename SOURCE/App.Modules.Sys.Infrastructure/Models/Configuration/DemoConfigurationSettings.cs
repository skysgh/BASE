namespace App.Modules.Sys.Substrate.Models.ConfigurationSettings
{
    using App.Modules.Sys.Substrate.tmp.Attributes;
    using App.Modules.Sys.Substrate.tmp.Constants;

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

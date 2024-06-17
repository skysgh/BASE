namespace App.Modules.Base.Substrate.tmp.Models.Messages._TOREVIEW.Entities.TenancySpecific
{
    using App.Modules.Base.Substrate.Models.Contracts;
    using App.Modules.Base.Substrate.tmp.Models.Entities.Base;

    /// <summary>
    /// A Permission that can be assigned directly to a Security Profile.
    /// </summary>
    public class PrincipalSecurityProfilePermission : TenantFKAuditedRecordStatedTimestampedGuidIdEntityBase, IHasTitleAndDescription
    {
        /// <summary>
        /// It's title
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// It's Description
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }

}


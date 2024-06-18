using App.Modules.Base.Substrate.tmp.Models.Entities.Base;
using App.Modules.Base.Substrate.tmp.Models.Messages._TOREVIEW.Entities.Enums;

namespace App.Modules.Base.Substrate.tmp.Models.Messages._TOREVIEW.Entities
{

    /// <summary>
    /// System entity (not exposed to the system's exterior) for
    /// a Data Classification (Normal, High, etc.) 
    /// to apply to a Resource.
    /// </summary>
    public class DataClassification : UntenantedAuditedRecordStatedTimestampedCustomIdReferenceDataEntityBase<NZDataClassification>
    {
    }
}
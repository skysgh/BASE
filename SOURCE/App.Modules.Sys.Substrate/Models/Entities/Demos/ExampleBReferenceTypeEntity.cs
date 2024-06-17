using App.Modules.Sys.Substrate.tmp.Attributes;
using App.Modules.Sys.Substrate.tmp.Models.Entities.Base;

namespace App.Modules.Sys.Substrate.tmp.Models.Entities.Demos
{
    /// <summary>
    /// A demonstration of a Reference Type Entity
    /// used to describe an instance of
    /// <see cref="ExampleBEntity"/>
    /// </summary>
    [ForDemoOnly]
    public class ExampleBReferenceTypeEntity :
        UntenantedAuditedRecordStatedTimestampedGuidIdReferenceDataEntityBase
    {

    }
}

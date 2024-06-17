using App.Modules.Base.Substrate.tmp.Attributes;
using App.Modules.Base.Substrate.tmp.Models.Entities.Base;

namespace App.Modules.Base.Substrate.tmp.Models.Entities.Demos
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

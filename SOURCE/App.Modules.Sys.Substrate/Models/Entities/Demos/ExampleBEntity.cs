using App.Modules.Sys.Substrate.tmp.Attributes;
using App.Modules.Sys.Substrate.tmp.Models.Entities.Base;

namespace App.Modules.Sys.Substrate.tmp.Models.Entities.Demos
{
    /// <summary>
    /// A slighly more complex example entity,
    /// with a single navigable property
    /// </summary>
    [ForDemoOnly]
    public class ExampleBEntity :
        UntenantedAuditedRecordStatedTimestampedGuidIdEntityBase
    {

        /// <summary>
        /// A Demo Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A Demo Description
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// A single Property FK
        /// </summary>
        public Guid SinglePropertyFK { get; set; }
        /// <summary>
        /// A single Property
        /// </summary>
        public ExampleBReferenceTypeEntity SingleProperty { get; set; }

    }
}

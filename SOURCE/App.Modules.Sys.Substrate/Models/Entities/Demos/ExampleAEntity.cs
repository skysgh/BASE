using App.Modules.Sys.Substrate.Models.Contracts;
using App.Modules.Sys.Substrate.Models.Contracts.Enums;
using App.Modules.Sys.Substrate.tmp.Attributes;
using App.Modules.Sys.Substrate.tmp.Factories;

namespace App.Modules.Sys.Substrate.tmp.Models.Entities.Demos
{
    /// <summary>
    /// Internal Simple (no Children) Demo Entity
    /// <para>
    /// Used to demonstrate correct mapping
    /// from an internal entity to an external
    /// entity, using an ObjectMapping 
    /// implementing
    /// <c></c>
    /// </para>
    /// </summary>
    [ForDemoOnly]
    public class ExampleAEntity :
        IHasGuidId,
        IHasRecordState,
        IHasEnabled,
        IHasTitle,
        IHasDescription
    {
        /// <inheritdoc/>
        public Guid Id { get; set; } = GuidFactory.NewGuid();

        /// <inheritdoc/>
        public RecordPersistenceState RecordState { get; set; }

        /// <inheritdoc/>
        public bool Enabled { get; set; }

        /// <inheritdoc/>
        public string Title { get; set; }

        /// <inheritdoc/>
        public string Description { get; set; }
    }
}

namespace App.Modules.Sys.Substrate.tmp.Models.Entities.Base
{
    using System;
    using App.Modules.Sys.Substrate.Models.Contracts;

    /// <summary>
    /// <para>
    /// Note that this Base runs parrallel to
    /// <see cref="TenantFKAuditedRecordStatedTimestampedGuidIdEntityBase"/>
    /// (inheritence line is based on Id Type).
    /// </para>
    /// 
    /// <para>
    /// Does Not Implements:
    /// <list type="bullet">
    /// <item><see cref="IHasGuidId"/></item>,
    /// </list>
    /// </para>
    /// 
    /// <para>
    /// Does Implements:
    /// <list type="bullet">
    /// <item><see cref="IHasId{T}"/></item>,
    /// <item><see cref="IHasTimestampRecordStateInRecordAuditability"/></item>
    /// </list>
    /// </para>
    /// 
    /// </summary>
    /// <typeparam name="TId"></typeparam>
    public abstract class TenantFKAuditedRecordStatedTimestampedCustomIdEntityBase<TId> :
        UntenantedAuditedRecordStatedTimestampedCustIdEntityBase<TId>,
        IHasTenantFK
        where TId : struct
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public TenantFKAuditedRecordStatedTimestampedCustomIdEntityBase() : base()
        {
            //REMEMBER: As not a Guid ID Must be provided somehow...
        }
        /// <inheritdoc/>

        public virtual Guid TenantFK { get; set; }
    }
}
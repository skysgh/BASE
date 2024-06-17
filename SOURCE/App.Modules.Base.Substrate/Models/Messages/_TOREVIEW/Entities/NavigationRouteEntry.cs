namespace App.Modules.Base.Substrate.tmp.Models.Messages._TOREVIEW.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using App.Modules.Base.Substrate.Models.Contracts;
    using App.Modules.Base.Substrate.tmp.Models.Entities.Base;

    /// <summary>
    /// An untenanted (ie, Universal/App) Navigation route entry.
    /// <see cref="TenantedNavigationRoute"/>
    /// </summary>
    public class NavigationRoute : UntenantedAuditedRecordStatedTimestampedGuidIdEntityBase, IHasGuidId, IHasOwnerFK, IHasText, IHasDescription, IHasDisplayOrderHint, IHasDisplayStyleHintNullable
    {
        // Class Not even used not sure what this was supposed to be

        /// <summary>
        /// FK of parent (Navigation Route)
        /// <para>
        /// TODO: Should this be nullable?
        /// </para>
        /// </summary>
        public Guid OwnerFK
        {
            get; set;
        }

        /// <summary>
        /// Get/Set whether the Route is enabled
        /// </summary>
        public bool Enabled
        {
            get; set;
        }

        /// <summary>
        /// Title to display
        /// </summary>
        public string Title
        {
            get; set;
        }
        /// <summary>
        /// Description of route to display
        /// </summary>
        public string Description
        {
            get; set;
        }

        /// <summary>
        /// Hint as to which order to display routes in a collection
        /// </summary>
        public int DisplayOrderHint
        {
            get; set;
        }
        /// <summary>
        /// Display hint as to style
        /// </summary>
        public string? DisplayStyleHint
        {
            get; set;
        }

        /// <summary>
        /// Collection of children/nested Routes
        /// </summary>
        public ICollection<NavigationRoute> Chilldren
        {
            get
            {
                return _children ??= new Collection<NavigationRoute>();
            }
        }

        private ICollection<NavigationRoute>? _children;


        /// <summary>
        /// Get the FK of the parent Route.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Guid GetOwnerFk()
        {
            throw new NotImplementedException();
        }
    }
}
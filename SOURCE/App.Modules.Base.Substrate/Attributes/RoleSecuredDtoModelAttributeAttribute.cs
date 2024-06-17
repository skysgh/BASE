namespace App.Modules.Base.Substrate.tmp.Attributes
{
    using System;

    /// <summary>
    /// TODO: Describe better
    /// </summary>
    public class RoleSecuredDtoModelAttributeAttribute : Attribute
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="roles"></param>
        public RoleSecuredDtoModelAttributeAttribute(string roles)
        {
            Roles = roles;
        }

        /// <summary>
        /// Get/set the Roles 
        /// <para>
        /// TODO: Describe use better.
        /// </para>
        /// </summary>
        public string Roles { get; set; }
    }
}
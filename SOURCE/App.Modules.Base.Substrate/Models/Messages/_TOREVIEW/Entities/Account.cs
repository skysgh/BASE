using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Modules.Base.Substrate.Models.Contracts;
using App.Modules.Base.Substrate.tmp.Models.Entities.Base;

namespace App.Modules.Base.Substrate.tmp.Models.Messages._TOREVIEW.Entities
{
    /// <summary>
    /// System entity (not exposed to the system's exterior) for
    /// an Account to which Users and Resources belong.
    /// </summary>
    public class Account : UntenantedAuditedRecordStatedTimestampedGuidIdEntityBase, IHasEnabled
    {
        /// <summary>
        /// Get/Set whether account is enabled or not.
        /// </summary>
        public bool Enabled { get; set; }
    }

}

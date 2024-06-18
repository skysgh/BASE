// using App.Modules.Base.Infrastructure.NewFolder.Services;
using Microsoft.Extensions.Logging;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Security.Policy;
// using System.Text;
// using System.Threading.Tasks;

namespace App.Modules.Base.Infrastructure.NewFolder.Services.Implementations
{
    /// <summary>
    /// Implementation of 
    /// <see cref="IResourceRouteManagementService"/>
    /// to rewrite requests as necessary.
    /// </summary>
    /// <remarks>
    /// Constructor
    /// </remarks>
    public class ResourceRouteManagementService(ILogger<ResourceRouteManagementService> logger) : IResourceRouteManagementService
    {
        private readonly ILogger<ResourceRouteManagementService> _logger = logger;

        /// <inheritdoc/>
        public string? Rewrite(string? resourceRoute)
        {
            if (resourceRoute == null)
            {
                return null;
            }
            // Rewrite to index
            if (resourceRoute!.Contains("/api/rest/host/v1/toberewritten"))
            {
                // rewrite and continue processing
                string newResourceRoute = "/api/rest/Host/v1/HostLayerExampleAEntity";
                _logger.LogTrace($"Rewriting Url ({resourceRoute}) to ({newResourceRoute})");
                resourceRoute = newResourceRoute;
            }

            return resourceRoute; //.ToUpper();
        }
    }
}

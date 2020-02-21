using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace Support.App_Start
{
    public class AccessPolicyCors :  ICorsPolicyProvider
    {
        public async Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var corsRequestContext = request.GetCorsRequestContext();
            var originRequested = corsRequestContext.Origin;

            if (await IsOriginFromCostumer(originRequested))
            {
                var policy = new CorsPolicy
                {
                    AllowAnyHeader = true,
                    AllowAnyMethod = true

                };
                policy.Origins.Add(originRequested);

                return policy;

            }
            return null;
        }


        private async Task<bool> IsOriginFromCostumer(string originRequested)
        {
            return true;
        }
    }
}
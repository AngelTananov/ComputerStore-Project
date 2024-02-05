using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace ComputerstoreApp.HealthChecks
{
    public class CustomHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {

            try
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("OK"));
            }
            catch (Exception e)
            {
                return Task.FromResult(
                    HealthCheckResult.Unhealthy(e.Message));
            }
        }
    }
}

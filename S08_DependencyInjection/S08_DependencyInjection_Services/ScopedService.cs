using S08_DependencyInjection_Services.Interfaces;

namespace S08_DependencyInjection_Services
{
    public class ScopedService : LifetimeMonitoringService, IScopedService
    {
        public ScopedService() : base()
        {
        }
    }
}

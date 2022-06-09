using S08_DependencyInjection_Services.Interfaces;

namespace S08_DependencyInjection_Services
{
    public class TransientService : LifetimeMonitoringService, ITransientService
    {
        public TransientService() : base()
        {
        }
    }
}

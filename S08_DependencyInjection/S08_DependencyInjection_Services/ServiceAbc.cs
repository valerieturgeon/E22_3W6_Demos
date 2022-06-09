using S08_DependencyInjection_Services.Interfaces;

namespace S08_DependencyInjection_Services
{
    public class ServiceAbc : MonitoringService, IServiceAbc
    {
        public ServiceAbc(ISingletonService singletonSvc, IScopedService scopedSvc, ITransientService transientSvc) : base(singletonSvc, scopedSvc, transientSvc)
        {
        }
    }
}

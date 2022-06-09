using S08_DependencyInjection_Services.Interfaces;

namespace S08_DependencyInjection_Services
{
    public class ServiceXyz : MonitoringService, IServiceXyz
    {
        public ServiceXyz(ISingletonService singletonSvc, IScopedService scopedSvc, ITransientService transientSvc) : base(singletonSvc, scopedSvc, transientSvc)
        {
        }
    }
}

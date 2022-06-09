using S08_DependencyInjection_Services.Interfaces;

namespace S08_DependencyInjection_Services
{
    public class SingletonService : LifetimeMonitoringService, ISingletonService
    {
        public SingletonService() : base()
        {
        }
    }
}

using S08_DependencyInjection_Models.ViewModels;

namespace S08_DependencyInjection_Services.Interfaces
{
    public interface IMonitoringService
    {
        MonitoringServiceInfosVM GetInfos { get; }
        void DoSomething();
    }
}

using S08_DependencyInjection_Models.ViewModels;

namespace S08_DependencyInjection_Services.Interfaces
{
    public interface ILifetimeMonitoringService
    {
        LifetimeServiceInfoVM GetInfos { get; }
        void DoSomething();
    }
}

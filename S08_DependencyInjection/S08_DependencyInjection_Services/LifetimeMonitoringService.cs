using S08_DependencyInjection_Models.ViewModels;
using S08_DependencyInjection_Services.Interfaces;
using System;

namespace S08_DependencyInjection_Services
{
    public class LifetimeMonitoringService : ILifetimeMonitoringService
    {
        private readonly Guid _guid;
        private int _count;

        public LifetimeMonitoringService()
        {
            _guid = Guid.NewGuid();
            _count = 0;
        }

        public LifetimeServiceInfoVM GetInfos => new LifetimeServiceInfoVM(GetType().Name, _guid, _count);

        public void DoSomething()
        {
            _count++;
        }
    }
}

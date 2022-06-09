using S08_DependencyInjection_Models.ViewModels;
using S08_DependencyInjection_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S08_DependencyInjection_Services
{
    public class MonitoringService : IMonitoringService
    {
        private readonly ISingletonService _singletonSvc;
        private readonly IScopedService _scopedSvc;
        private readonly ITransientService _transientSvc;

        public MonitoringService(ISingletonService singletonSvc, IScopedService scopedSvc, ITransientService transientSvc)
        {
            _singletonSvc = singletonSvc;
            _scopedSvc = scopedSvc;
            _transientSvc = transientSvc;
        }

        public MonitoringServiceInfosVM GetInfos => new MonitoringServiceInfosVM(GetType().Name, new List<LifetimeServiceInfoVM> { _singletonSvc.GetInfos, _scopedSvc.GetInfos, _transientSvc.GetInfos });

        public void DoSomething()
        {
            _singletonSvc.DoSomething();
            _scopedSvc.DoSomething();
            _transientSvc.DoSomething();
        }
    }
}

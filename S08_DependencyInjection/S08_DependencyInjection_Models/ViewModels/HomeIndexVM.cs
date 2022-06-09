using System.Collections.Generic;

namespace S08_DependencyInjection_Models.ViewModels
{
    public class HomeIndexVM
    {
        public HomeIndexVM()
        {
            MonitoringServicesInfos = new List<MonitoringServiceInfosVM>();
        }
        public HomeIndexVM(List<MonitoringServiceInfosVM> servicesInfos)
        {
            MonitoringServicesInfos = servicesInfos;
        }

        public List<MonitoringServiceInfosVM> MonitoringServicesInfos { get; set; }
    }
}

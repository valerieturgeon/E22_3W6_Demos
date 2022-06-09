using System.Collections.Generic;

namespace S08_DependencyInjection_Models.ViewModels
{
    public class MonitoringServiceInfosVM
    {
        public MonitoringServiceInfosVM()
        {
            LifetimeServicesInfos = new List<LifetimeServiceInfoVM>();
        }
        public MonitoringServiceInfosVM(string name) : this()
        {
            Name = name;
        }
        public MonitoringServiceInfosVM(string name, List<LifetimeServiceInfoVM> dependenciesInfos) : this(name)
        {
            LifetimeServicesInfos = dependenciesInfos;
        }

        public string Name { get; set; }
        public List<LifetimeServiceInfoVM> LifetimeServicesInfos { get; set; }
    }
}

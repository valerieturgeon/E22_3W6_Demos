using System;

namespace S08_DependencyInjection_Models.ViewModels
{
    public class LifetimeServiceInfoVM
    {
        public LifetimeServiceInfoVM()
        {
        }
        public LifetimeServiceInfoVM(string name, Guid guid, int value)
        {
            Name = name;
            Guid = guid;
            CounterValue = value;
        }

        public string Name { get; set; }
        public Guid Guid { get; set; }
        public int CounterValue { get; set; }
    }
}

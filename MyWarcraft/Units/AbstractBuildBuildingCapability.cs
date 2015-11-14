using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Uwarcraft.Units

{
    public abstract class AbstractBuildBuildingCapability
    {
        public event BuildingComplete BuildingComplete;

        public List<AbstractBuildBuildingCapability> NewCapabilities;

        public string Name { get; set; }
        public string Description { get; set; }

        public abstract void Build();

        protected void OnBuildComplete()
        {
            if (BuildingComplete != null)
            {
                var arg = new BuildingCompleteEventArgs();
                arg.Capabilities = new ObservableCollection<AbstractBuildBuildingCapability>();
                foreach (var capability in NewCapabilities)
                {
                    arg.Capabilities.Add(capability);
                }

                BuildingComplete.Invoke(this, arg);
            }
        }
    }
}
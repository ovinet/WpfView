using System;
using System.Collections.ObjectModel;

namespace Uwarcraft.Units
{
    public class BuildingCompleteEventArgs : EventArgs
    {
        public ObservableCollection<AbstractBuildBuildingCapability> Capabilities { get; set; }
    }
}

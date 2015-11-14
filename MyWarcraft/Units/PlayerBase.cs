using Microsoft.Practices.Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Uwarcraft.Units
{
    public class PlayerBase : BindableBase
    {
        public ObservableCollection<AbstractBuildBuildingCapability> BuildBuildingsCapabilities
        {
            get; set;
        }

        public ObservableCollection<AbstractBuildUnitCapability> BuildUnitsCapabilities
        {
            get; set;
        }

        public PlayerBase()
        {
            BuildBuildingsCapabilities = new ObservableCollection<AbstractBuildBuildingCapability>();
            BuildBuildingsCapabilities.Add(new BuildFarmCapability());

            BuildUnitsCapabilities = new ObservableCollection<AbstractBuildUnitCapability>();
            BuildUnitsCapabilities.Add(new BuildPeasantCapability());
        }
    }
}
using System.Collections.Generic;

namespace Uwarcraft.Units
{
    public class PlayerBase
    {
        public List<AbstractBuildBuildingCapability> BuildBuildingsCapabilities
        {
            get; set;
        }

        public List<AbstractBuildUnitCapability> BuildUnitsCapabilities
        {
            get; set;
        }

        public PlayerBase()
        {
            BuildBuildingsCapabilities = new List<AbstractBuildBuildingCapability>();
            BuildBuildingsCapabilities.Add(new BuildFarmCapability());

            BuildUnitsCapabilities = new List<AbstractBuildUnitCapability>();
            BuildUnitsCapabilities.Add(new BuildPeasantCapability());
        }
    }
}
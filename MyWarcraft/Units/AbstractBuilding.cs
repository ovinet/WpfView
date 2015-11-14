using System.Collections.Generic;

namespace Uwarcraft.Units
{
    public abstract class AbstractBuilding : AbstractBuildable
    {
        public List<AbstractBuildUnitCapability> BuildUnitCapabilities { get; protected set; }
        public List<AbstractBuildBuildingCapability> BuildBuildingsCapabilities { get; protected set; }
    }
}

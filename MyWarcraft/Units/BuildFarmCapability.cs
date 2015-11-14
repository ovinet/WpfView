using System.Collections.Generic;

namespace Uwarcraft.Units
{
    public class BuildFarmCapability : AbstractBuildBuildingCapability
    {
        public BuildFarmCapability()
        {
            Name = "Farm";
            Description = "builds a farm";
        }

        public override void Build()
        {
            var farm = new Farm();
            NewCapabilities = new List<AbstractBuildBuildingCapability>();
            NewCapabilities.Add(new BuildBarrackCapability());

            farm.BuildingComplete += Farm_BuildingComplete;
            farm.StartBuilding();
        }

        private void Farm_BuildingComplete(object sender, BuildingCompleteEventArgs e)
        {
            OnBuildComplete();
        }
    }
}
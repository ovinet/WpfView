using System.Collections.Generic;

namespace Uwarcraft.Units
{
    public class BuildBarrackCapability : AbstractBuildBuildingCapability
    {
        public BuildBarrackCapability()
        {
            Name = "Barrack";
            Description = "builds a barrack";
        }

        public override void Build()
        {
            var barrack = new Barrack();
            NewCapabilities = new List<AbstractBuildBuildingCapability>();
            NewCapabilities.Add(new BuildBarrackCapability());

            barrack.BuildingComplete += Farm_BuildingComplete;
            barrack.StartBuilding();
        }

        private void Farm_BuildingComplete(object sender, BuildingCompleteEventArgs e)
        {
            OnBuildComplete();
        }
    }
}
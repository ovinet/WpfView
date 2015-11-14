namespace Uwarcraft.Units
{
    public class BuildFarmCapability : AbstractBuildBuildingCapability
    {
        public override IBuildable Build()
        {
            return new Farm();
        }
    }
}
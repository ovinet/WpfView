namespace Uwarcraft.Units
{
    public class BuildPeasantCapability : AbstractBuildUnitCapability
    {
        public override AbstractUnit Build()
        {
            Peasant peasant = new Peasant();
            peasant.StartBuilding();
            return peasant;
        }
    }
}
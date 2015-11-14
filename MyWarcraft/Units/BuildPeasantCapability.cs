namespace Uwarcraft.Units
{
    public class BuildPeasantCapability : AbstractBuildUnitCapability
    {
        public BuildPeasantCapability()
        {
            Name = "Peasant";
            Description = "Builds a peasant.";
        }

        public override AbstractUnit Build()
        {
            Peasant peasant = new Peasant();
            peasant.StartBuilding();
            return peasant;
        }
    }
}
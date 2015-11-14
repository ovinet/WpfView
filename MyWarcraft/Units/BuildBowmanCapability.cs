namespace Uwarcraft.Units
{
    public class BuildBowmanCapability : AbstractBuildUnitCapability
    {
        public override AbstractUnit Build()
        {
            Bowman bowman = new Bowman();
            bowman.StartBuilding();
            return bowman;
        }
    }
}
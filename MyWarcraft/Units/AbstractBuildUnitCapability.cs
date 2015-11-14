namespace Uwarcraft.Units
{
    public abstract class AbstractBuildUnitCapability
    {
        public string Description { get; set; }

        public abstract AbstractUnit Build();
    }
}
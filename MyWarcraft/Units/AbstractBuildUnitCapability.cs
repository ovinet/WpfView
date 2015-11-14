namespace Uwarcraft.Units
{
    public abstract class AbstractBuildUnitCapability
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract AbstractUnit Build();
    }
}
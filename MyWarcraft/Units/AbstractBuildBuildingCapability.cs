namespace Uwarcraft.Units

{
    public abstract class AbstractBuildBuildingCapability
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract IBuildable Build();
    }
}
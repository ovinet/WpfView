namespace Uwarcraft.Units

{
    public abstract class AbstractBuildBuildingCapability
    {
        public string Description { get; set; }

        public abstract IBuildable Build();
    }
}
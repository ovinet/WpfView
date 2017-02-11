using MyWarcraft.Models;

namespace MyWarcraft.Models.Events
{
    public delegate void UnderConstruction(AbstractBuildable sender, ConstructionArgs args);
}

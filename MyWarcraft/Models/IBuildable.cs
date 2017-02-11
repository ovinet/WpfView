using MyWarcraft.Models.Events;

namespace MyWarcraft.Models
{
    public interface IBuildable
    {
        int Id { get; set; }
        event BuildingComplete BuildingComplete;
        int PercentageBuilt { get; set; }
        void StartBuilding();
        void Ready(int percentage);
    }
}

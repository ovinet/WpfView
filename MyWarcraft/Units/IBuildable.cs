namespace Uwarcraft.Units
{
    public interface IBuildable
    {
        event BuildingComplete BuildingComplete;
        int PercentageBuilt { get; set; }
        void StartBuilding();
        void Ready(int percentage);
    }
}

using Microsoft.Practices.Prism.Mvvm;
using MyWarcraft.Models.Buildings;
using System.Collections.ObjectModel;

namespace MyWarcraft.Models
{
    public class PlayerBase : BindableBase
    {
        public ObservableCollection<AbstractBuildable> Components
        {
            get; set;
        }

        public AbstractBuildable SelectedComponent
        {
            get; set;
        }

        public PlayerBase()
        {
            Components = new ObservableCollection<AbstractBuildable>();
            var farm1 = new Farm();
            var farm2 = new Farm();
            Components.Add(farm1);
            Components.Add(farm2);
            farm1.StartBuilding();
            farm2.StartBuilding();
        }

        public void AddComponent(AbstractBuildable component)
        {
            Components.Add(component);
        }
    }
}
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using System.Windows.Input;
using Uwarcraft.Units;

namespace MyWarcraft.ViewModels
{
    public class BuildingCapabilityViewModel : BindableBase
    {
        public ICommand Build { get; private set; }
        public AbstractBuildBuildingCapability BuildCapability { get; set; }

        public BuildingCapabilityViewModel(AbstractBuildBuildingCapability buildCapability)
        {
            BuildCapability = buildCapability;
            Build = new DelegateCommand<object>(BuildBuilding);
        }

        public void BuildBuilding(object obj)
        {
            BuildCapability.Build();
        }
    }

}

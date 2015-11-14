using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using Uwarcraft.Units;

namespace MyWarcraft.ViewModels
{
    public class PlayerBaseViewModel : BindableBase
    {
        private PlayerBase playerBase;
        public ObservableCollection<BuildingCapabilityViewModel> BuildBuildingsCapabilities { get; set; }

        private Dictionary<string, BuildingCapabilityViewModel> capabilitiesDictionary;

        public PlayerBase PlayerBase
        {
            get
            {
                return playerBase;
            }

            set
            {
                SetProperty(ref this.playerBase, value);
            }
        }
        public PlayerBaseViewModel()
        {
            playerBase = new PlayerBase();
            capabilitiesDictionary = new Dictionary<string, BuildingCapabilityViewModel>();
            BuildBuildingsCapabilities = new ObservableCollection<BuildingCapabilityViewModel>();
            AddCapabilities(playerBase.BuildBuildingsCapabilities);
        }

        private void Capability_BuildingComplete(object sender, BuildingCompleteEventArgs e)
        {
            AddCapabilities(e.Capabilities);
        }

        private void AddCapabilities(ObservableCollection<AbstractBuildBuildingCapability> capabilities)
        {
            foreach (var capability in capabilities)
            {
                if (capabilitiesDictionary.ContainsKey(capability.Name))
                {
                    continue;
                }
                Application.Current.Dispatcher.BeginInvoke(new Action(() =>
                {
                    capability.BuildingComplete += Capability_BuildingComplete;
                    var capVM = new BuildingCapabilityViewModel(capability);
                    BuildBuildingsCapabilities.Add(capVM);
                    capabilitiesDictionary.Add(capability.Name, capVM);
                }));
            }
        }

    }
}

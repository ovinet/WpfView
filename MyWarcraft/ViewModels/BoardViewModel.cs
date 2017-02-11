using Microsoft.Practices.Prism.Mvvm;
using System.Collections.ObjectModel;
using MyWarcraft.Models;
using MyWarcraft.Models.Events;
using Microsoft.Practices.Prism.Commands;
using System.Windows.Input;
using System.Windows;
using MyWarcraft.Models.Board;
using MyWarcraft.Models.Buildings;

namespace MyWarcraft.ViewModels
{
    public class BoardViewModel : BindableBase
    {
        public ICommand Click { get; protected set; }
        public ObservableCollection<TileViewModel> TileVMs { get; set; }
        private Pawn pawn;
        private PawnViewModel selectedComponent;
        public PawnViewModel SelectedComponent
        {
            get
            {
                return selectedComponent;
            }

            set
            {
                selectedComponent = value;
                OnPropertyChanged("SelectedComponent");
            }
        }

        public ObservableCollection<PawnViewModel> PawnVMs { get; private set; }

        public BoardViewModel(Map map, Pawn p)
        {
            TileVMs = new ObservableCollection<TileViewModel>();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    TileVMs.Add(new TileViewModel(map.Tiles[i, j], i, j));
                }
            }
           


            pawn = p;
            PawnVMs = new ObservableCollection<PawnViewModel>();
            Click = new DelegateCommand<IInputElement>(OnBoadLeftClick);
        }

        private void OnBoadLeftClick(IInputElement parameter)
        {
            if (SelectedComponent!=null)
            {
                var point = Mouse.GetPosition(parameter); 
                SelectedComponent.Move((int)point.X, (int)point.Y);
            }
        }

        private void ComponentVM_ComponentSelected(object sender, ComponentSelectedEventArgs e)
        {
            UnbindSelectedComponentCapabilities();
            SelectedComponent = e.ComponentVM;
            BindSelectedComponentCapabilities();
        }

        private void BindSelectedComponentCapabilities()
        {
            if (selectedComponent != null && selectedComponent.Pawn != null)
            {
            }
        }

        private void Capability_BuildingStarted(object sender, Models.Events.BuildingStartedEventArgs e)
        {
            var component = e.Component;
        
        }

        private void UnbindSelectedComponentCapabilities()
        {
            
        }

        private void Components_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            foreach (var item in e.NewItems)
            {
                var componentVM = new PawnViewModel((Pawn)item);
                componentVM.ComponentSelected += ComponentVM_ComponentSelected;
                PawnVMs.Add(componentVM);
            }
        }
    }
}

using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using MyWarcraft.Models;
using MyWarcraft.Models.Events;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyWarcraft.ViewModels
{
    public class PawnViewModel : BindableBase
    {
        public ICommand Click { get; protected set; }
        public event ComponentSelected ComponentSelected;
        public int Life { get; set; }

        public Pawn Pawn { get; set; }

        public ObservableCollection<BuildingCapabilityViewModel> BuildingCapabilitiesVMs { get; set; }
        public ObservableCollection<BuildingCapabilityViewModel> UnitsCapabilitiesVMs { get; set; }

        public PawnViewModel(Pawn pawn)
        {
            Pawn = pawn;
        }

        internal void Move(int x, int y)
        {
            Pawn.MoveToLocation(new Point(x,y));
        }
    }
}

using Microsoft.Practices.Prism.Mvvm;
using MyWarcraft.Models.Events;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MyWarcraft.Models.Board;

namespace MyWarcraft.ViewModels
{
    public class TileViewModel : BindableBase
    {
        private int x;
        private int y;

        public Tile Tile{ get; set; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public TileViewModel(Tile tile, int i, int j)
        {
            X = i;
            Y = j;
        }
    }
}

using Microsoft.Practices.Prism.Mvvm;
using MyWarcraft.Models;

namespace MyWarcraft.ViewModels
{
    public class PlayerViewModel : BindableBase
    {
        private Player player;
        public BoardViewModel BoardVM { get; set; }

        public Player Player
        {
            get
            {
                return player;
            }

            set
            {
                SetProperty(ref this.player, value);
            }
        }

        public PlayerViewModel(Player player)
        {
            Player = player;
            BoardVM = new BoardViewModel(player.Map, player.Pawn);
        }
    }
}

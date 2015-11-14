using Microsoft.Practices.Prism.Mvvm;

namespace MyWarcraft.ViewModels
{
    public class GameViewModel : BindableBase
    {
        public GameViewModel()
        {
            this.PlayerBaseViewModel = new PlayerBaseViewModel();
        }

        public PlayerBaseViewModel PlayerBaseViewModel { get; set; }
    }
}

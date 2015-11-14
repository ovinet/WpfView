using Microsoft.Practices.Prism.Mvvm;
using Uwarcraft.Units;

namespace MyWarcraft.ViewModels
{
    public class PlayerBaseViewModel : BindableBase
    {
        private PlayerBase playerBase;

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
        }
    }
}

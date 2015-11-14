using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

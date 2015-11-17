using Microsoft.Practices.Prism.Mvvm;

namespace MyWarcraft.ViewModels
{
    public class Position: BindableBase
    {
        private int x;
        private int y;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
                OnPropertyChanged("X");
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
                OnPropertyChanged("Y");
            }
        }
    }
}
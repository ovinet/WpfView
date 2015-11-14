using Microsoft.Practices.Prism.Mvvm;
using MyWarcraft.ViewModels;
using System.Windows;

namespace MyWarcraft
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

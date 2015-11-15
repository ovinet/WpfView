using Microsoft.Practices.Prism.Mvvm;
using MyWarcraft.ViewModels;
using NLog;
using System.Windows;

namespace MyWarcraft
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public PlayerBaseViewModel PlayerBaseVM { get; set; }
        public MainWindow()
        {
            logger.Trace("MainWindow created");
            InitializeComponent();
            PlayerBaseVM = new PlayerBaseViewModel();
            this.DataContext = this;
            logger.Trace("MainWindow initialized");
        }
    }
}

using Microsoft.Practices.Prism.Mvvm;
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
        public MainWindow()
        {
            logger.Trace("MainWindow created");
            InitializeComponent();

            logger.Trace("MainWindow initialized");
        }
    }
}

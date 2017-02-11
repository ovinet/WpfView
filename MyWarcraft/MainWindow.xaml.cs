using Microsoft.Practices.Prism.Mvvm;
using MyWarcraft.Models;
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
        private static Game game;
        private Player player1;

        public PlayerViewModel PlayerVM { get; set; }
        public MainWindow()
        {
            logger.Trace("MainWindow created");
            InitializeComponent();

            Init();
            player1.ReadCommands();
            player1.ExecuteCommands();


            PlayerVM = new PlayerViewModel(player1);
            this.DataContext = this;
            logger.Trace("MainWindow initialized");
        }

        void Init()
        {
            game = Game.Instance;
            game.Load("SavedGames\\Map.txt");
            ICommandReader commandReader = new FileCommandReader();
            // ICommandReader commandReader = new TcpCommandReader();
            player1 = new Player(game.Map, commandReader);
        }
    }
}

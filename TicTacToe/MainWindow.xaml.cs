using System.Windows;


namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor

        /// <summary>
        /// Default constuctor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            NewGame();

        }

        #endregion
        private void NewGame()
        {
            throw new NotImlementedException();
        }
    }
}

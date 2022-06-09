using System.Windows;

namespace AsyncUIExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();

            viewModel = new MainViewModel();
            DataContext = viewModel;
        }
    }
}

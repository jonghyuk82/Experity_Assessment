using Experity_Assessment.Interfaces;
using Experity_Assessment.ViewModels;
using System.Windows;

namespace Experity_Assessment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>        
    public partial class MainWindow : Window
    {
        private readonly IPrintService _printService;
        private readonly EventViewModel _eventViewModel;
        public MainWindow(IPrintService printService, EventViewModel eventViewModel)
        {
            InitializeComponent();
            _printService = printService;
            _eventViewModel = eventViewModel;
            DataContext = _eventViewModel;
        }
    }
}

using NyaaDB.Api.DBIntegration;
using NyaaDB.Impl.DBIntegration;
using NyaaDB.Impl.Settings;
using NyaaDB.Api.Settings;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NyaaDB.Api.AnimeDB;
using NyaaDB.ViewModel;

namespace NyaaDB.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _mainWindowViewModel;
        private readonly DefaultDBSettings _dbSettings;
        private readonly DBManager _dbManager;
        private const string _magnetPrefix = @"magnet:?xt=urn:btih:";

        MainWindowViewModel ViewModel
        {
            get { return _mainWindowViewModel; }
            set { _mainWindowViewModel = value; DataContext = _mainWindowViewModel; }
        }

        public MainWindow(DefaultDBSettings aDefaultDBSettings, DBManager aDefaultDBManager)
        {
            InitializeComponent();

            _dbSettings = aDefaultDBSettings;
            _dbManager = aDefaultDBManager;

            ViewModel = new MainWindowViewModel();

            var s = new SearchSpecification()
            {
                SearchSortOrder = SortOrder.DESC,
                SearchBy = "date"
            };



            var res = _dbManager.SearchAnime("", s);
            res.ForEach(x => ViewModel.TorrentCollection.Add(new NyaaTorrentViewModel(x)));

            res.Clear();
        }

        private void MagnetButton_ClickEvent(object sender, RoutedEventArgs e)
        {
            try
            {
                var dc = ((Button)sender).DataContext as NyaaTorrentViewModel;
                Process.Start(_magnetPrefix + dc.TorrentHash);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
    }
}

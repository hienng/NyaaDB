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
                SearchCat = new Category(),
                SearchSortOrder = SortOrder.ASC,
                SearchBy = "date"
            };



            var res = _dbManager.SearchAnime("test", s);
            res.ForEach(x => ViewModel.TorrentCollection.Add(new NyaaTorrentViewModel(x)));


            //var b = new SubCategory();
            //b.SubCatType = SubCategoryType.ANIME_ENG;
            //var s = new SearchSpecification()
            //{
            //    SearchCat = b,
            //    SearchSortOrder = SortOrder.ASC,
            //    SearchBy = "date"
            //};

            //try
            //{
            //    var r = _dbManager.SearchAnime("[horriblesubs] one piece", s);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("No Database found.", "Database Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //}


            //try
            //{
            //    Process.Start("magnet:?xt=urn:btih:" + res.First().TorrentHash);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("No Torrent Client detected", "Local Torrent Client Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //}
        }
    }
}

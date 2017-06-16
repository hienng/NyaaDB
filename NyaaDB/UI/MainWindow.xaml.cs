using NyaaDB.Impl.DBIntegration;
using NyaaDB.Impl.Settings;
using NyaaDB.UI.Api.Settings;
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

namespace NyaaDB.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DefaultDBSettings _dbSettings;

        public MainWindow(DefaultDBSettings aDefaultDBSettings)
        {
            InitializeComponent();

            _dbSettings = aDefaultDBSettings;

            var res = new DefaultDBManager(_dbSettings).SearchAnime("one piece");
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

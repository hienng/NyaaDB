using NyaaDB.Api.AnimeDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaaDB.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<NyaaTorrentViewModel> _torrentCollection = new ObservableCollection<NyaaTorrentViewModel>();
        private string _searchKeyword = string.Empty;

        public MainWindowViewModel()
        {
        }

        public ObservableCollection<NyaaTorrentViewModel> TorrentCollection
        {
            get { return _torrentCollection; }
            set { _torrentCollection = value; OnPropertyChanged(); }
        }
    }
}

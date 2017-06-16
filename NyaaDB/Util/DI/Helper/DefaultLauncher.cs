using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyaaDB.UI.Util.DI.Helper
{
    class DefaultLauncher : Launcher
    {
        private readonly MainWindow _mainWindow;

        public DefaultLauncher(MainWindow aMainWindow)
        {
            _mainWindow = aMainWindow;
        }

        public void Run()
        {
            _mainWindow.Show();
        }
    }
}

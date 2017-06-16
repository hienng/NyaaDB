using Castle.Windsor;
using Castle.Windsor.Installer;
using NyaaDB.UI.Util.DI.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NyaaDB
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IWindsorContainer _container;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            _container = new WindsorContainer();
            _container.Install(FromAssembly.This());

            _container.Resolve<Launcher>().Run();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            _container.Dispose();
        }
    }
}

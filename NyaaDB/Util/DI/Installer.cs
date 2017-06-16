using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using NyaaDB.UI.Util.DI.Helper;
using NyaaDB.Impl.Settings;
using NyaaDB.Api.DBIntegration;
using NyaaDB.Impl.DBIntegration;
using NyaaDB.UI;

namespace NyaaDB.Util.DI
{
    public class Installer : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container

                // DBManager
                .Register(Component.For<DBManager>().ImplementedBy<DummyDBManager>())

                // Settings
                .Register(Component.For<DefaultDBSettings>())

                // Entry point
                .Register(Component.For<Launcher>().ImplementedBy<DefaultLauncher>().LifestyleTransient())

                // MainWindow
                .Register(Component.For<MainWindow>());
        }
    }
}

﻿using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using NyaaDB.UI.Util.DI.Helper;
using NyaaDB.UI.Api.Settings;
using NyaaDB.Impl.Settings;

namespace NyaaDB.UI.Util.DI
{
    public class Installer : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container
                // Settings
                .Register(Component.For<DefaultDBSettings>())

                // Entry point
                .Register(Component.For<Launcher>().ImplementedBy<DefaultLauncher>().LifestyleTransient())

                // MainWindow
                .Register(Component.For<MainWindow>());
        }
    }
}

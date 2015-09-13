using Prism.Unity;
using System.Windows;
using Prism.Regions;
using Microsoft.Practices.Unity;
using PrismMahAppsSample.Infrastructure.Constants;
using Prism.Modularity;
using PrismMahAppsSample.Shell.Views;
using PrismMahAppsSample.Infrastructure.Services;
using PrismMahAppsSample.Infrastructure;

namespace PrismMahAppsSample.Shell
{
    public class Bootstrapper : UnityBootstrapper
    {
        /// <summary>
        /// The shell object
        /// </summary>
        /// <returns></returns>
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        /// <summary>
        /// Intialize shell (MainWindow)
        /// </summary>
        protected override void InitializeShell()
        {
            base.InitializeShell();

            // Register view
            var regionManager = this.Container.Resolve<IRegionManager>();
            if (regionManager != null)
            {
                // Add right windows commands
                regionManager.RegisterViewWithRegion(RegionNames.RightWindowCommandsRegions, typeof(RightTitlebarCommands));
                // Add flyouts
                regionManager.RegisterViewWithRegion(RegionNames.FlyoutRegion, typeof(SettingsFlyout));
                // Add tiles to MainRegion
                regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(HomeTiles));
            }

            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterType<IApplicationCommands, ApplicationCommandsProxy>();
            Container.RegisterInstance<IFlyoutService>(Container.Resolve<FlyoutService>());
        }

        /// <summary>
        /// Configure the module catalog
        /// </summary>
        protected override void ConfigureModuleCatalog()
        {
            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            // Register ModuleA
            moduleCatalog.AddModule(typeof(ModuleA.ModuleA));
            // Register ModuleB
            moduleCatalog.AddModule(typeof(ModuleB.ModuleB));
        }
    }
}
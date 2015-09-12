using Prism.Unity;
using PrismMahAppsSample.Views;
using System.Windows;
using Prism.Regions;
using MahApps.Metro.Controls;
using PrismMahAppsSample.Shell.RegionAdapter;
using Microsoft.Practices.Unity;
using PrismMahAppsSample.Infrastructure.Constants;
using Prism.Modularity;

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
            return new MainWindow();
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
                regionManager.AddToRegion(RegionNames.RightWindowCommandsRegions, new Views.RightTitlebarCommands());
                // Add flyouts
                regionManager.AddToRegion(RegionNames.FlyoutRegion, new Views.SettingsFlyout());
                // Add tiles to MainRegion
                regionManager.AddToRegion(RegionNames.MainRegion, new Views.HomeTiles());
            }

            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }

        /// <summary>
        /// Configure the module catalog
        /// </summary>
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;

            // Register ModuleA
            moduleCatalog.AddModule(typeof(PrismMahAppsSample.ModuleA.ModuleA));
            // Register ModuleB
            moduleCatalog.AddModule(typeof(PrismMahAppsSample.ModuleB.ModuleB));
        }

        /// <summary>
        /// Register region adapter mappings
        /// </summary>
        /// <returns></returns>
        protected override RegionAdapterMappings ConfigureRegionAdapterMappings()
        {
            RegionAdapterMappings mappings = base.ConfigureRegionAdapterMappings();

            // Register RegionAdapters
            mappings.RegisterMapping(typeof(FlyoutsControl), Container.Resolve<FlyoutRegionAdapter>());
            mappings.RegisterMapping(typeof(WindowCommands), Container.Resolve<TitleBarWindowCommandsRegionAdapter>());

            return mappings;
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
        }
    }
}
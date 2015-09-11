using MahApps.Metro.Controls;
using Microsoft.Practices.ServiceLocation;
using Prism.Mvvm;
using Prism.Regions;
using PrismMahAppsSample.Infrastructure.Constants;
using PrismMahAppsSample.Shell.ViewModels;
using System;
using System.Collections.Generic;
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

namespace PrismMahAppsSample.Views
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            // TODO: Uses ViewModelLocator (PRISM-LIB)
            this.DataContext = new MainWindowViewModel();

            // TODO: Workaround -> the XAML-Declaration doesn't work for this region types (declaration outside of the metro window)???
            IRegionManager regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            if (regionManager != null)
            {
                RegionManager.SetRegionName(this.leftWindowsCommandRegion, RegionNames.LeftWindowCommandsRegions);
                RegionManager.SetRegionManager(this.leftWindowsCommandRegion, regionManager);

                RegionManager.SetRegionName(this.rightWindowsCommandRegion, RegionNames.RightWindowCommandsRegions);
                RegionManager.SetRegionManager(this.rightWindowsCommandRegion, regionManager);

                RegionManager.SetRegionName(this.flyoutsControlRegion, RegionNames.FlyoutRegion);
                RegionManager.SetRegionManager(this.flyoutsControlRegion, regionManager);
            }
        }
    }
}
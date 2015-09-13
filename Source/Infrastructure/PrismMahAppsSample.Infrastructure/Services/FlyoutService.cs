using MahApps.Metro.Controls;
using Prism.Commands;
using Prism.Regions;
using PrismMahAppsSample.Infrastructure.Constants;
using PrismMahAppsSample.Infrastructure.Interfaces;
using System.Linq;
using System.Windows.Input;

namespace PrismMahAppsSample.Infrastructure.Services
{
    public class FlyoutService : IFlyoutService
    {
        IRegionManager _regionManager;

        public ICommand ShowFlyoutCommand { get; private set; }

        public FlyoutService(IRegionManager regionManager, IApplicationCommands applicationCommands)
        {
            _regionManager = regionManager;

            ShowFlyoutCommand = new DelegateCommand<string>(ShowFlyout, CanShowFlyout);
            applicationCommands.ShowFlyoutCommand.RegisterCommand(ShowFlyoutCommand);
        }

        public void ShowFlyout(string flyoutName)
        {
            var region = _regionManager.Regions[RegionNames.FlyoutRegion];

            if (region != null)
            {
                var flyout = region.Views.Where(v => v is IFlyoutView && ((IFlyoutView)v).FlyoutName.Equals(flyoutName)).FirstOrDefault() as Flyout;

                if (flyout != null)
                {
                    flyout.IsOpen = !flyout.IsOpen;
                }
            }
        }

        public bool CanShowFlyout(string flyoutName)
        {
            return true;
        }
    }
}

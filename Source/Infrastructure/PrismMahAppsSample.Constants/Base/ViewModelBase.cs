using MahApps.Metro.Controls;
using Microsoft.Practices.Unity;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismMahAppsSample.Infrastructure.Constants;
using PrismMahAppsSample.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PrismMahAppsSample.Infrastructure.Base
{
    public abstract class ViewModelBase : BindableBase
    {
        /// <summary>
        /// Standard CTOR
        /// </summary>
        public ViewModelBase()
        {
            this.UnityContainer = Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<IUnityContainer>();
            this.RegionManager = Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<IRegionManager>();

            // Initialize commands
            this.InitializeCommands();
        }

        #region Commands

        /// <summary>
        /// Initialize commands
        /// </summary>
        private void InitializeCommands()
        {
            this.ToggleFlyoutCommand = new DelegateCommand<string>(this.OnToogleFlyoutCommandExecute, this.OnToggleFlyoutCommandCanExecute);
        }

        /// <summary>
        /// Toggle flyout command
        /// </summary>
        public ICommand ToggleFlyoutCommand { get; private set; }

        /// <summary>
        /// Toggle flyout command can execute
        /// </summary>
        /// <param name="flyoutName"></param>
        /// <returns></returns>
        private bool OnToggleFlyoutCommandCanExecute(string flyoutName)
        {
            return true;
        }

        /// <summary>
        /// Toggle flyout command execute
        /// </summary>
        /// <param name="flyoutName"></param>
        private void OnToogleFlyoutCommandExecute(string flyoutName)
        {
            var region = this.RegionManager.Regions[RegionNames.FlyoutRegion];

            if (region != null)
            {
                var flyout = region.Views.Where(v => v is IFlyoutView && ((IFlyoutView)v).FlyoutName.Equals(flyoutName)).FirstOrDefault() as Flyout;

                if (flyout != null)
                {
                    flyout.IsOpen = !flyout.IsOpen;
                }
            }
        }

        #endregion Commands

        #region Properties

        private IUnityContainer unityContainer;

        /// <summary>
        /// The unity container
        /// </summary>
        public IUnityContainer UnityContainer
        {
            get { return unityContainer; }
            private set { this.SetProperty<IUnityContainer>(ref this.unityContainer, value); }
        }

        private IRegionManager regionManager;

        /// <summary>
        /// The region manager
        /// </summary>
        public IRegionManager RegionManager
        {
            get { return regionManager; }
            private set { this.SetProperty<IRegionManager>(ref this.regionManager, value); }
        }

        #endregion Properties
    }
}
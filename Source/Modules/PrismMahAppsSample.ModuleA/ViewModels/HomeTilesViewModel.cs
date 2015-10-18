using Prism.Commands;
using PrismMahAppsSample.Infrastructure.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Practices.Unity;
using PrismMahAppsSample.Infrastructure.Constants;
using PrismMahAppsSample.Infrastructure.Interfaces;

namespace PrismMahAppsSample.ModuleA.ViewModels
{
    public class HomeTilesViewModel : ViewModelBase
    {
        public HomeTilesViewModel()
        {
            // Initialize commands
            this.IntializeCommands();
        }

        #region Commands

        /// <summary>
        /// Initialize commands
        /// </summary>
        private void IntializeCommands()
        {
            this.ShowModuleAPopupCommand = new DelegateCommand(this.ShowModuleAPopup, this.CanShowModuleAPoupup);
            this.ShowModuleAMessageCommand = new DelegateCommand(this.ShowModuleAMessage, this.CanShowModuleAMessage);
        }

        /// <summary>
        /// Show popup
        /// </summary>
        public ICommand ShowModuleAPopupCommand { get; private set; }

        public bool CanShowModuleAPoupup()
        {
            return true;
        }

        public void ShowModuleAPopup()
        {
            this.RegionManager.RequestNavigate(RegionNames.DialogPopupRegion, PopupNames.ModuleAPopup);
        }

        /// <summary>
        /// Show popup
        /// </summary>
        public ICommand ShowModuleAMessageCommand { get; private set; }

        public bool CanShowModuleAMessage()
        {
            return true;
        }

        /// <summary>
        /// Show message
        /// </summary>
        public void ShowModuleAMessage()
        {
            this.Container.Resolve<IMetroMessageDisplayService>(ServiceNames.MetroMessageDisplayService).ShowMessageAsnyc("Module A Message", "This is a message from Module A");
        }

        #endregion Commands
    }
}
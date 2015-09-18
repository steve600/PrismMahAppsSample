using MahApps.Metro.Controls;
using Microsoft.Practices.Unity;
using PrismMahAppsSample.Infrastructure.Constants;
using PrismMahAppsSample.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MahApps.Metro.Controls.Dialogs;
using System.Windows.Controls;

namespace PrismMahAppsSample.Infrastructure.Services
{
    public class MetroMessageDisplayService : IMetroMessageDisplayService
    {
        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="container">Unity container.</param>
        public MetroMessageDisplayService(IUnityContainer container)
        {
            this.MainWindow = container.Resolve<Window>(WindowNames.MainWindowName) as MetroWindow;
        }

        #region Properties

        private MetroWindow mainWindow;

        /// <summary>
        /// The main window
        /// </summary>
        public MetroWindow MainWindow
        {
            get { return mainWindow; }
            private set { mainWindow = value; }
        }

        #endregion Properties

        public async Task<MessageDialogResult> ShowMessageAsnyc(string title, string message, MessageDialogStyle style = MessageDialogStyle.Affirmative, MetroDialogSettings settings = null)
        {
            this.MainWindow.MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Accented;

            return await this.MainWindow.ShowMessageAsync(title, message, style, this.MainWindow.MetroDialogOptions);
        }

    }
}

using MahApps.Metro.Controls;
using PrismMahAppsSample.Infrastructure.Constants;
using PrismMahAppsSample.Infrastructure.Interfaces;

namespace PrismMahAppsSample.Shell.Views
{
    /// <summary>
    /// Interaktionslogik für SettingsFlyout.xaml
    /// </summary>
    public partial class SettingsFlyout : Flyout, IFlyoutView
    {
        public SettingsFlyout()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The flyout name
        /// </summary>
        public string FlyoutName
        {
            get { return FlyoutNames.ShellSettingsFlyout; }
        }
    }
}

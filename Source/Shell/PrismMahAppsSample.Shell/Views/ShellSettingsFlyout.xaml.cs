using MahApps.Metro.Controls;
using PrismMahAppsSample.Infrastructure.Constants;
using PrismMahAppsSample.Infrastructure.Interfaces;

namespace PrismMahAppsSample.Shell.Views
{
    /// <summary>
    /// Interaktionslogik für ShellSettingsFlyout.xaml
    /// </summary>
    public partial class ShellSettingsFlyout : Flyout, IFlyoutView
    {
        public ShellSettingsFlyout()
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

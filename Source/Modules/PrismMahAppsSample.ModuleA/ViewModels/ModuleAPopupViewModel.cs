using PrismMahAppsSample.Infrastructure.Base;
using PrismMahAppsSample.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PrismMahAppsSample.ModuleA.ViewModels
{
    public class ModuleAPopupViewModel : ViewModelDialogPopupBase
    {
        /// <summary>
        /// The view title
        /// </summary>
        public override string Title
        {
            get
            {
                return "Module A - Custom Popup";
            }
        }

        /// <summary>
        /// The dialog icon
        /// </summary>
        public override ImageSource Icon
        {
            get
            {
                return Application.Current.Resources["add_on_16x16"] as ImageSource;
            }
        }
    }
}

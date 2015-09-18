using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PrismMahAppsSample.Infrastructure.Base
{
    public abstract class ViewModelDialogPopupBase : BindableBase
    {
        /// <summary>
        /// View title
        /// </summary>
        public abstract string Title { get; }

        /// <summary>
        /// The dialog icon
        /// </summary>
        public abstract ImageSource Icon { get; }
    }
}

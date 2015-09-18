using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismMahAppsSample.Infrastructure.Interfaces
{
    public interface IMetroMessageDisplayService
    {
        Task<MessageDialogResult> ShowMessageAsnyc(string title, string message, MessageDialogStyle style = MessageDialogStyle.Affirmative, MetroDialogSettings settings = null);
    }
}

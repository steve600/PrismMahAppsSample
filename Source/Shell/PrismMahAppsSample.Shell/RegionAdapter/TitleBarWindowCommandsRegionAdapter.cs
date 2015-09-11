using MahApps.Metro.Controls;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismMahAppsSample.Shell.RegionAdapter
{
    public class TitleBarWindowCommandsRegionAdapter : RegionAdapterBase<WindowCommands>
    {
        public TitleBarWindowCommandsRegionAdapter(IRegionBehaviorFactory factory)
         : base(factory)
        {

        }

        protected override void Adapt(IRegion region, WindowCommands regionTarget)
        {
            region.Views.CollectionChanged += (s, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (FrameworkElement element in e.NewItems)
                    {
                        regionTarget.Items.Add(element);
                    }
                }

                // TODO: implement remove
            };
        }

        protected override IRegion CreateRegion()
        {
            return new AllActiveRegion();
        }
    }
}

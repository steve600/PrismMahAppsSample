using MahApps.Metro.Controls;
using Prism.Regions;
using System.Collections.Specialized;
using System.Windows;

namespace PrismMahAppsSample.Shell.RegionAdapter
{
    public class FlyoutRegionAdapter : RegionAdapterBase<FlyoutsControl>
    {
        public FlyoutRegionAdapter(IRegionBehaviorFactory factory)
         : base(factory)
        {

        }

    protected override void Adapt(IRegion region, FlyoutsControl regionTarget)
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

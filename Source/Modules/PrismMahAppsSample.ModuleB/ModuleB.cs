using Microsoft.Practices.Unity;
using Prism.Regions;
using PrismMahAppsSample.Infrastructure.Base;
using PrismMahAppsSample.Infrastructure.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismMahAppsSample.ModuleB
{
    public class ModuleB : PrismBaseModule
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="unityContainer">The Unity container.</param>
        /// <param name="regionManager">The region manager.</param>
        public ModuleB(IUnityContainer unityContainer, IRegionManager regionManager) :
            base(unityContainer, regionManager)
        {
            // Titlebar
            regionManager.AddToRegion(RegionNames.LeftWindowCommandsRegions, new Views.LeftTitlebarCommands());

            // Flyouts
            regionManager.AddToRegion(RegionNames.FlyoutRegion, new Views.C1Flyout());

            // Tiles
            regionManager.AddToRegion(RegionNames.MainRegion, new Views.HomeTiles());
        }
    }
}
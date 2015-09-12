using Microsoft.Practices.Unity;
using Prism.Regions;
using PrismMahAppsSample.Infrastructure.Base;
using PrismMahAppsSample.Infrastructure.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismMahAppsSample.ModuleA
{
    public class ModuleA : PrismBaseModule
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="unityContainer">The Unity container.</param>
        /// <param name="regionManager">The region manager.</param>
        public ModuleA(IUnityContainer unityContainer, IRegionManager regionManager) :
            base(unityContainer, regionManager)
        {
            // Titlebar
            regionManager.AddToRegion(RegionNames.RightWindowCommandsRegions, new Views.RightTitlebarCommands());

            // Flyouts
            regionManager.AddToRegion(RegionNames.FlyoutRegion, new Views.C1Flyout());
            regionManager.AddToRegion(RegionNames.FlyoutRegion, new Views.C2Flyout());

            // Tiles
            regionManager.AddToRegion(RegionNames.MainRegion, new Views.HomeTiles());
        }
    }
}
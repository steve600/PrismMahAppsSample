using Microsoft.Practices.Unity;
using Prism.Regions;
using PrismMahAppsSample.Infrastructure.Base;
using PrismMahAppsSample.Infrastructure.Constants;
using PrismMahAppsSample.ModuleA.Views;

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
            regionManager.RegisterViewWithRegion(RegionNames.RightWindowCommandsRegion, typeof(RightTitlebarCommands));

            // Flyouts
            regionManager.RegisterViewWithRegion(RegionNames.FlyoutRegion, typeof(C1Flyout));
            regionManager.RegisterViewWithRegion(RegionNames.FlyoutRegion, typeof(C2Flyout));

            // Tiles
            regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(HomeTiles));

            // Register Views
            Prism.Unity.UnityExtensions.RegisterTypeForNavigation<Views.ModuleAPopup>(unityContainer, PopupNames.ModuleAPopup);
        }
    }
}
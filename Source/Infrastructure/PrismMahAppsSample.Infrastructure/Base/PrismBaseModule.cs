using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismMahAppsSample.Infrastructure.Base
{
    public abstract class PrismBaseModule : IModule
    {
        #region Members and Constants

        private IUnityContainer unityContainer;
        private IRegionManager regionManager;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="unityContainer">The Unity container.</param>
        /// <param name="regionManager">The region manager.</param>
        /// <param name="regionViewRegistry">The region view registry.</param>
        public PrismBaseModule(IUnityContainer unityContainer, IRegionManager regionManager)
        {
            this.UnityContainer = unityContainer;
            this.regionManager = regionManager;
        }

        #endregion Ctor

        #region Interface IModule

        /// <summary>
        /// Initialize module
        /// </summary>
        public virtual void Initialize()
        {

        }

        #endregion Interface IModule

        #region Properties

        /// <summary>
        /// The Unity container
        /// </summary>
        public IUnityContainer UnityContainer
        {
            get { return this.unityContainer; }
            private set { this.unityContainer = value; }
        }

        /// <summary>
        /// The region manager
        /// </summary>
        public IRegionManager RegionManager
        {
            get { return this.regionManager; }
            private set { this.regionManager = value; }
        }

        #endregion Properties
    }
}
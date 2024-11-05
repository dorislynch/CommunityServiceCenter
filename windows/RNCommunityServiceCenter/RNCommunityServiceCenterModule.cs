using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Community.Service.Center.RNCommunityServiceCenter
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCommunityServiceCenterModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCommunityServiceCenterModule"/>.
        /// </summary>
        internal RNCommunityServiceCenterModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCommunityServiceCenter";
            }
        }
    }
}

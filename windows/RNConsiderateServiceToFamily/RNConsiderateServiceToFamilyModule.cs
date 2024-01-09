using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Considerate.Service.To.Family.RNConsiderateServiceToFamily
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNConsiderateServiceToFamilyModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNConsiderateServiceToFamilyModule"/>.
        /// </summary>
        internal RNConsiderateServiceToFamilyModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNConsiderateServiceToFamily";
            }
        }
    }
}

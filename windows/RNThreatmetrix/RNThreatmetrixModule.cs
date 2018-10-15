using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Threatmetrix.RNThreatmetrix
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNThreatmetrixModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNThreatmetrixModule"/>.
        /// </summary>
        internal RNThreatmetrixModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNThreatmetrix";
            }
        }
    }
}

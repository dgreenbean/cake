// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Cake.Common.Solution
{
    /// <summary>
    /// Represents the configuration and platform pair in a solution file.
    /// </summary>
    public class SolutionConfigurationPlatform
    {
        /// <summary>
        /// Gets the configuration.
        /// </summary>
        public string Configuration { get; }

        /// <summary>
        /// Gets the platform.
        /// </summary>
        public string Platform { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionConfigurationPlatform" /> class./>
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <param name="platform">The platform.</param>
        public SolutionConfigurationPlatform(string configuration, string platform)
        {
            Configuration = configuration;
            Platform = platform;
        }
    }
}

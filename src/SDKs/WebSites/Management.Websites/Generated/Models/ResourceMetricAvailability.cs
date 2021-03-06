// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Metrics availability and retention.
    /// </summary>
    public partial class ResourceMetricAvailability
    {
        /// <summary>
        /// Initializes a new instance of the ResourceMetricAvailability class.
        /// </summary>
        public ResourceMetricAvailability() { }

        /// <summary>
        /// Initializes a new instance of the ResourceMetricAvailability class.
        /// </summary>
        /// <param name="timeGrain">Time grain .</param>
        /// <param name="retention">Retention period for the current time
        /// grain.</param>
        public ResourceMetricAvailability(string timeGrain = default(string), string retention = default(string))
        {
            TimeGrain = timeGrain;
            Retention = retention;
        }

        /// <summary>
        /// Gets time grain .
        /// </summary>
        [JsonProperty(PropertyName = "timeGrain")]
        public string TimeGrain { get; protected set; }

        /// <summary>
        /// Gets retention period for the current time grain.
        /// </summary>
        [JsonProperty(PropertyName = "retention")]
        public string Retention { get; protected set; }

    }
}


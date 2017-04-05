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
    /// Network access control entry.
    /// </summary>
    public partial class NetworkAccessControlEntry
    {
        /// <summary>
        /// Initializes a new instance of the NetworkAccessControlEntry class.
        /// </summary>
        public NetworkAccessControlEntry() { }

        /// <summary>
        /// Initializes a new instance of the NetworkAccessControlEntry class.
        /// </summary>
        /// <param name="action">Action object. Possible values include:
        /// 'Permit', 'Deny'</param>
        /// <param name="description">Description.</param>
        /// <param name="order">Order of precedence.</param>
        /// <param name="remoteSubnet">Remote subnet.</param>
        public NetworkAccessControlEntry(AccessControlEntryAction? action = default(AccessControlEntryAction?), string description = default(string), int? order = default(int?), string remoteSubnet = default(string))
        {
            Action = action;
            Description = description;
            Order = order;
            RemoteSubnet = remoteSubnet;
        }

        /// <summary>
        /// Gets or sets action object. Possible values include: 'Permit',
        /// 'Deny'
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public AccessControlEntryAction? Action { get; set; }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets order of precedence.
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or sets remote subnet.
        /// </summary>
        [JsonProperty(PropertyName = "remoteSubnet")]
        public string RemoteSubnet { get; set; }

    }
}

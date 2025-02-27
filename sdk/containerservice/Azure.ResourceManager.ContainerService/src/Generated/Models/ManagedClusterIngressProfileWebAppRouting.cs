// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Web App Routing settings for the ingress profile. </summary>
    public partial class ManagedClusterIngressProfileWebAppRouting
    {
        /// <summary> Initializes a new instance of <see cref="ManagedClusterIngressProfileWebAppRouting"/>. </summary>
        public ManagedClusterIngressProfileWebAppRouting()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterIngressProfileWebAppRouting"/>. </summary>
        /// <param name="isEnabled"> Whether to enable Web App Routing. </param>
        /// <param name="dnsZoneResourceId"> Resource ID of the DNS Zone to be associated with the web app. Used only when Web App Routing is enabled. </param>
        internal ManagedClusterIngressProfileWebAppRouting(bool? isEnabled, ResourceIdentifier dnsZoneResourceId)
        {
            IsEnabled = isEnabled;
            DnsZoneResourceId = dnsZoneResourceId;
        }

        /// <summary> Whether to enable Web App Routing. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Resource ID of the DNS Zone to be associated with the web app. Used only when Web App Routing is enabled. </summary>
        public ResourceIdentifier DnsZoneResourceId { get; set; }
    }
}

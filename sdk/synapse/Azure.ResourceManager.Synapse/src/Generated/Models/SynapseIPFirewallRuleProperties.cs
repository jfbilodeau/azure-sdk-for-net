// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> IP firewall rule properties. </summary>
    public partial class SynapseIPFirewallRuleProperties
    {
        /// <summary> Initializes a new instance of <see cref="SynapseIPFirewallRuleProperties"/>. </summary>
        public SynapseIPFirewallRuleProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseIPFirewallRuleProperties"/>. </summary>
        /// <param name="endIPAddress"> The end IP address of the firewall rule. Must be IPv4 format. Must be greater than or equal to startIpAddress. </param>
        /// <param name="provisioningState"> Resource provisioning state. </param>
        /// <param name="startIPAddress"> The start IP address of the firewall rule. Must be IPv4 format. </param>
        internal SynapseIPFirewallRuleProperties(IPAddress endIPAddress, SynapseProvisioningState? provisioningState, IPAddress startIPAddress)
        {
            EndIPAddress = endIPAddress;
            ProvisioningState = provisioningState;
            StartIPAddress = startIPAddress;
        }

        /// <summary> The end IP address of the firewall rule. Must be IPv4 format. Must be greater than or equal to startIpAddress. </summary>
        public IPAddress EndIPAddress { get; set; }
        /// <summary> Resource provisioning state. </summary>
        public SynapseProvisioningState? ProvisioningState { get; }
        /// <summary> The start IP address of the firewall rule. Must be IPv4 format. </summary>
        public IPAddress StartIPAddress { get; set; }
    }
}

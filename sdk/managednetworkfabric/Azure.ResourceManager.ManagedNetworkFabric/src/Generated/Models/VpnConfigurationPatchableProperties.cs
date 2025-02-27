// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Network and credential configuration currently applied on terminal server. </summary>
    public partial class VpnConfigurationPatchableProperties
    {
        /// <summary> Initializes a new instance of <see cref="VpnConfigurationPatchableProperties"/>. </summary>
        public VpnConfigurationPatchableProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VpnConfigurationPatchableProperties"/>. </summary>
        /// <param name="networkToNetworkInterconnectId"> ARM Resource ID of the Network To Network Interconnect. </param>
        /// <param name="peeringOption"> Peering option list. </param>
        /// <param name="optionBProperties"> option B properties. </param>
        /// <param name="optionAProperties"> option A properties. </param>
        internal VpnConfigurationPatchableProperties(ResourceIdentifier networkToNetworkInterconnectId, PeeringOption? peeringOption, OptionBProperties optionBProperties, VpnConfigurationPatchableOptionAProperties optionAProperties)
        {
            NetworkToNetworkInterconnectId = networkToNetworkInterconnectId;
            PeeringOption = peeringOption;
            OptionBProperties = optionBProperties;
            OptionAProperties = optionAProperties;
        }

        /// <summary> ARM Resource ID of the Network To Network Interconnect. </summary>
        public ResourceIdentifier NetworkToNetworkInterconnectId { get; set; }
        /// <summary> Peering option list. </summary>
        public PeeringOption? PeeringOption { get; set; }
        /// <summary> option B properties. </summary>
        public OptionBProperties OptionBProperties { get; set; }
        /// <summary> option A properties. </summary>
        public VpnConfigurationPatchableOptionAProperties OptionAProperties { get; set; }
    }
}

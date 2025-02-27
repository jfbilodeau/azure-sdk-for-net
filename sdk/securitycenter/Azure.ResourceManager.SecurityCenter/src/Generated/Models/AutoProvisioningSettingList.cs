// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of all the auto provisioning settings response. </summary>
    internal partial class AutoProvisioningSettingList
    {
        /// <summary> Initializes a new instance of <see cref="AutoProvisioningSettingList"/>. </summary>
        internal AutoProvisioningSettingList()
        {
            Value = new ChangeTrackingList<AutoProvisioningSettingData>();
        }

        /// <summary> Initializes a new instance of <see cref="AutoProvisioningSettingList"/>. </summary>
        /// <param name="value"> List of all the auto provisioning settings. </param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        internal AutoProvisioningSettingList(IReadOnlyList<AutoProvisioningSettingData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of all the auto provisioning settings. </summary>
        public IReadOnlyList<AutoProvisioningSettingData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}

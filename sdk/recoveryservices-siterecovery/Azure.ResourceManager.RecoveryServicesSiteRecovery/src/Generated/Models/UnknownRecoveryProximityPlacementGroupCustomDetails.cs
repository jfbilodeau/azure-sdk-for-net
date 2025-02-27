// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownRecoveryProximityPlacementGroupCustomDetails. </summary>
    internal partial class UnknownRecoveryProximityPlacementGroupCustomDetails : RecoveryProximityPlacementGroupCustomDetails
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRecoveryProximityPlacementGroupCustomDetails"/>. </summary>
        /// <param name="resourceType"> The class type. </param>
        internal UnknownRecoveryProximityPlacementGroupCustomDetails(string resourceType) : base(resourceType)
        {
            ResourceType = resourceType ?? "Unknown";
        }
    }
}

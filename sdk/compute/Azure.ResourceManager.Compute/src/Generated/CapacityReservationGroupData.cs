// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute
{
    /// <summary>
    /// A class representing the CapacityReservationGroup data model.
    /// Specifies information about the capacity reservation group that the capacity reservations should be assigned to. Currently, a capacity reservation can only be added to a capacity reservation group at creation time. An existing capacity reservation cannot be added or moved to another capacity reservation group.
    /// </summary>
    public partial class CapacityReservationGroupData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="CapacityReservationGroupData"/>. </summary>
        /// <param name="location"> The location. </param>
        public CapacityReservationGroupData(AzureLocation location) : base(location)
        {
            Zones = new ChangeTrackingList<string>();
            CapacityReservations = new ChangeTrackingList<SubResource>();
            VirtualMachinesAssociated = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="CapacityReservationGroupData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="zones"> Availability Zones to use for this capacity reservation group. The zones can be assigned only during creation. If not provided, the group supports only regional resources in the region. If provided, enforces each capacity reservation in the group to be in one of the zones. </param>
        /// <param name="capacityReservations"> A list of all capacity reservation resource ids that belong to capacity reservation group. </param>
        /// <param name="virtualMachinesAssociated"> A list of references to all virtual machines associated to the capacity reservation group. </param>
        /// <param name="instanceView"> The capacity reservation group instance view which has the list of instance views for all the capacity reservations that belong to the capacity reservation group. </param>
        internal CapacityReservationGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IList<string> zones, IReadOnlyList<SubResource> capacityReservations, IReadOnlyList<SubResource> virtualMachinesAssociated, CapacityReservationGroupInstanceView instanceView) : base(id, name, resourceType, systemData, tags, location)
        {
            Zones = zones;
            CapacityReservations = capacityReservations;
            VirtualMachinesAssociated = virtualMachinesAssociated;
            InstanceView = instanceView;
        }

        /// <summary> Availability Zones to use for this capacity reservation group. The zones can be assigned only during creation. If not provided, the group supports only regional resources in the region. If provided, enforces each capacity reservation in the group to be in one of the zones. </summary>
        public IList<string> Zones { get; }
        /// <summary> A list of all capacity reservation resource ids that belong to capacity reservation group. </summary>
        public IReadOnlyList<SubResource> CapacityReservations { get; }
        /// <summary> A list of references to all virtual machines associated to the capacity reservation group. </summary>
        public IReadOnlyList<SubResource> VirtualMachinesAssociated { get; }
        /// <summary> The capacity reservation group instance view which has the list of instance views for all the capacity reservations that belong to the capacity reservation group. </summary>
        internal CapacityReservationGroupInstanceView InstanceView { get; }
        /// <summary> List of instance view of the capacity reservations under the capacity reservation group. </summary>
        public IReadOnlyList<CapacityReservationInstanceViewWithName> InstanceViewCapacityReservations
        {
            get => InstanceView?.CapacityReservations;
        }
    }
}

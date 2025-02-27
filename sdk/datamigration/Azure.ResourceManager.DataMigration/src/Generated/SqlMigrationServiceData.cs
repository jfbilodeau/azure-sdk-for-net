// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataMigration
{
    /// <summary>
    /// A class representing the SqlMigrationService data model.
    /// A SQL Migration Service.
    /// </summary>
    public partial class SqlMigrationServiceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SqlMigrationServiceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public SqlMigrationServiceData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlMigrationServiceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state to track the async operation status. </param>
        /// <param name="integrationRuntimeState"> Current state of the Integration runtime. </param>
        internal SqlMigrationServiceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string provisioningState, string integrationRuntimeState) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            IntegrationRuntimeState = integrationRuntimeState;
        }

        /// <summary> Provisioning state to track the async operation status. </summary>
        public string ProvisioningState { get; }
        /// <summary> Current state of the Integration runtime. </summary>
        public string IntegrationRuntimeState { get; }
    }
}

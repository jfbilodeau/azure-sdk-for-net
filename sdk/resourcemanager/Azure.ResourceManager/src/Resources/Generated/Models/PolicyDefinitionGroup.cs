// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The policy definition group. </summary>
    public partial class PolicyDefinitionGroup
    {
        /// <summary> Initializes a new instance of <see cref="PolicyDefinitionGroup"/>. </summary>
        /// <param name="name"> The name of the group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public PolicyDefinitionGroup(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="PolicyDefinitionGroup"/>. </summary>
        /// <param name="name"> The name of the group. </param>
        /// <param name="displayName"> The group's display name. </param>
        /// <param name="category"> The group's category. </param>
        /// <param name="description"> The group's description. </param>
        /// <param name="additionalMetadataId"> A resource ID of a resource that contains additional metadata about the group. </param>
        internal PolicyDefinitionGroup(string name, string displayName, string category, string description, string additionalMetadataId)
        {
            Name = name;
            DisplayName = displayName;
            Category = category;
            Description = description;
            AdditionalMetadataId = additionalMetadataId;
        }

        /// <summary> The name of the group. </summary>
        public string Name { get; set; }
        /// <summary> The group's display name. </summary>
        public string DisplayName { get; set; }
        /// <summary> The group's category. </summary>
        public string Category { get; set; }
        /// <summary> The group's description. </summary>
        public string Description { get; set; }
        /// <summary> A resource ID of a resource that contains additional metadata about the group. </summary>
        public string AdditionalMetadataId { get; set; }
    }
}

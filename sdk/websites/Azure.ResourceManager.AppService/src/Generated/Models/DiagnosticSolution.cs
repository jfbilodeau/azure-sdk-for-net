// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Class Representing Solution for problems detected. </summary>
    public partial class DiagnosticSolution
    {
        /// <summary> Initializes a new instance of <see cref="DiagnosticSolution"/>. </summary>
        public DiagnosticSolution()
        {
            Data = new ChangeTrackingList<IList<AppServiceNameValuePair>>();
            Metadata = new ChangeTrackingList<IList<AppServiceNameValuePair>>();
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticSolution"/>. </summary>
        /// <param name="id"> Solution Id. </param>
        /// <param name="displayName"> Display Name of the solution. </param>
        /// <param name="order"> Order of the solution. </param>
        /// <param name="description"> Description of the solution. </param>
        /// <param name="solutionType"> Type of Solution. </param>
        /// <param name="data"> Solution Data. </param>
        /// <param name="metadata"> Solution Metadata. </param>
        internal DiagnosticSolution(double? id, string displayName, double? order, string description, DiagnosticSolutionType? solutionType, IList<IList<AppServiceNameValuePair>> data, IList<IList<AppServiceNameValuePair>> metadata)
        {
            Id = id;
            DisplayName = displayName;
            Order = order;
            Description = description;
            SolutionType = solutionType;
            Data = data;
            Metadata = metadata;
        }

        /// <summary> Solution Id. </summary>
        public double? Id { get; set; }
        /// <summary> Display Name of the solution. </summary>
        public string DisplayName { get; set; }
        /// <summary> Order of the solution. </summary>
        public double? Order { get; set; }
        /// <summary> Description of the solution. </summary>
        public string Description { get; set; }
        /// <summary> Type of Solution. </summary>
        public DiagnosticSolutionType? SolutionType { get; set; }
        /// <summary> Solution Data. </summary>
        public IList<IList<AppServiceNameValuePair>> Data { get; }
        /// <summary> Solution Metadata. </summary>
        public IList<IList<AppServiceNameValuePair>> Metadata { get; }
    }
}

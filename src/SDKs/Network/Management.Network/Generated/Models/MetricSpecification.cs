// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Description of metrics specification.
    /// </summary>
    public partial class MetricSpecification
    {
        /// <summary>
        /// Initializes a new instance of the MetricSpecification class.
        /// </summary>
        public MetricSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricSpecification class.
        /// </summary>
        /// <param name="name">The name of the metric.</param>
        /// <param name="displayName">The display name of the metric.</param>
        /// <param name="displayDescription">The description of the
        /// metric.</param>
        /// <param name="unit">Units the metric to be displayed in.</param>
        /// <param name="aggregationType">The aggregation type.</param>
        /// <param name="availabilities">List of availability.</param>
        /// <param name="enableRegionalMdmAccount">Whether regional MDM account
        /// enabled.</param>
        /// <param name="fillGapWithZero">Whether gaps would be filled with
        /// zeros.</param>
        /// <param name="metricFilterPattern">Pattern for the filter of the
        /// metric.</param>
        /// <param name="dimensions">List of dimensions.</param>
        /// <param name="isInternal">Whether the metric is internal.</param>
        /// <param name="sourceMdmAccount">The source MDM account.</param>
        /// <param name="sourceMdmNamespace">The source MDM namespace.</param>
        /// <param name="resourceIdDimensionNameOverride">The resource Id
        /// dimension name override.</param>
        public MetricSpecification(string name = default(string), string displayName = default(string), string displayDescription = default(string), string unit = default(string), string aggregationType = default(string), IList<Availability> availabilities = default(IList<Availability>), bool? enableRegionalMdmAccount = default(bool?), bool? fillGapWithZero = default(bool?), string metricFilterPattern = default(string), IList<Dimension> dimensions = default(IList<Dimension>), bool? isInternal = default(bool?), string sourceMdmAccount = default(string), string sourceMdmNamespace = default(string), string resourceIdDimensionNameOverride = default(string))
        {
            Name = name;
            DisplayName = displayName;
            DisplayDescription = displayDescription;
            Unit = unit;
            AggregationType = aggregationType;
            Availabilities = availabilities;
            EnableRegionalMdmAccount = enableRegionalMdmAccount;
            FillGapWithZero = fillGapWithZero;
            MetricFilterPattern = metricFilterPattern;
            Dimensions = dimensions;
            IsInternal = isInternal;
            SourceMdmAccount = sourceMdmAccount;
            SourceMdmNamespace = sourceMdmNamespace;
            ResourceIdDimensionNameOverride = resourceIdDimensionNameOverride;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display name of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the description of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "displayDescription")]
        public string DisplayDescription { get; set; }

        /// <summary>
        /// Gets or sets units the metric to be displayed in.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets the aggregation type.
        /// </summary>
        [JsonProperty(PropertyName = "aggregationType")]
        public string AggregationType { get; set; }

        /// <summary>
        /// Gets or sets list of availability.
        /// </summary>
        [JsonProperty(PropertyName = "availabilities")]
        public IList<Availability> Availabilities { get; set; }

        /// <summary>
        /// Gets or sets whether regional MDM account enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enableRegionalMdmAccount")]
        public bool? EnableRegionalMdmAccount { get; set; }

        /// <summary>
        /// Gets or sets whether gaps would be filled with zeros.
        /// </summary>
        [JsonProperty(PropertyName = "fillGapWithZero")]
        public bool? FillGapWithZero { get; set; }

        /// <summary>
        /// Gets or sets pattern for the filter of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "metricFilterPattern")]
        public string MetricFilterPattern { get; set; }

        /// <summary>
        /// Gets or sets list of dimensions.
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<Dimension> Dimensions { get; set; }

        /// <summary>
        /// Gets or sets whether the metric is internal.
        /// </summary>
        [JsonProperty(PropertyName = "isInternal")]
        public bool? IsInternal { get; set; }

        /// <summary>
        /// Gets or sets the source MDM account.
        /// </summary>
        [JsonProperty(PropertyName = "sourceMdmAccount")]
        public string SourceMdmAccount { get; set; }

        /// <summary>
        /// Gets or sets the source MDM namespace.
        /// </summary>
        [JsonProperty(PropertyName = "sourceMdmNamespace")]
        public string SourceMdmNamespace { get; set; }

        /// <summary>
        /// Gets or sets the resource Id dimension name override.
        /// </summary>
        [JsonProperty(PropertyName = "resourceIdDimensionNameOverride")]
        public string ResourceIdDimensionNameOverride { get; set; }

    }
}

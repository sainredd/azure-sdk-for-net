// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Azure;
    using Management;
    using ServiceBus;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Create Or Update Authorization Rules
    /// operation.
    /// </summary>
    [JsonTransformation]
    public partial class SharedAccessAuthorizationRuleCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleCreateOrUpdateParameters class.
        /// </summary>
        public SharedAccessAuthorizationRuleCreateOrUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleCreateOrUpdateParameters class.
        /// </summary>
        /// <param name="rights">The rights associated with the rule.</param>
        /// <param name="location">data center location.</param>
        /// <param name="name">Name of the authorization rule.</param>
        public SharedAccessAuthorizationRuleCreateOrUpdateParameters(IList<AccessRights?> rights, string location = default(string), string name = default(string))
        {
            Location = location;
            Name = name;
            Rights = rights;
        }

        /// <summary>
        /// Gets or sets data center location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets name of the authorization rule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the rights associated with the rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rights")]
        public IList<AccessRights?> Rights { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Rights == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Rights");
            }
        }
    }
}

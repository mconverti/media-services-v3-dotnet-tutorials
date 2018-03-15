// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The input to the check name availability request.
    /// </summary>
    public partial class CheckNameAvailabilityInput
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityInput class.
        /// </summary>
        public CheckNameAvailabilityInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityInput class.
        /// </summary>
        /// <param name="name">The account name.</param>
        /// <param name="type">The account type. For a Media Services account,
        /// this should be 'MediaServices'.</param>
        public CheckNameAvailabilityInput(string name = default(string), string type = default(string))
        {
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the account name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the account type. For a Media Services account, this
        /// should be 'MediaServices'.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}

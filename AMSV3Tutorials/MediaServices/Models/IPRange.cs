// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The IP address range in the CIDR scheme.
    /// </summary>
    public partial class IPRange
    {
        /// <summary>
        /// Initializes a new instance of the IPRange class.
        /// </summary>
        public IPRange()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IPRange class.
        /// </summary>
        /// <param name="name">The friendly name for the IP address
        /// range.</param>
        /// <param name="address">The IP address.</param>
        /// <param name="subnetPrefixLength">The subnet mask prefix length (see
        /// CIDR notation).</param>
        public IPRange(string name = default(string), string address = default(string), int? subnetPrefixLength = default(int?))
        {
            Name = name;
            Address = address;
            SubnetPrefixLength = subnetPrefixLength;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the friendly name for the IP address range.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the IP address.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the subnet mask prefix length (see CIDR notation).
        /// </summary>
        [JsonProperty(PropertyName = "subnetPrefixLength")]
        public int? SubnetPrefixLength { get; set; }

    }
}

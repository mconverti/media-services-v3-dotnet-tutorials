// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// StreamingEndpoint access control definition.
    /// </summary>
    public partial class StreamingEndpointAccessControl
    {
        /// <summary>
        /// Initializes a new instance of the StreamingEndpointAccessControl
        /// class.
        /// </summary>
        public StreamingEndpointAccessControl()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StreamingEndpointAccessControl
        /// class.
        /// </summary>
        /// <param name="akamai">The access control of Akamai</param>
        /// <param name="ip">The IP access control of the
        /// StreamingEndpoint.</param>
        public StreamingEndpointAccessControl(AkamaiAccessControl akamai = default(AkamaiAccessControl), IPAccessControl ip = default(IPAccessControl))
        {
            Akamai = akamai;
            Ip = ip;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the access control of Akamai
        /// </summary>
        [JsonProperty(PropertyName = "akamai")]
        public AkamaiAccessControl Akamai { get; set; }

        /// <summary>
        /// Gets or sets the IP access control of the StreamingEndpoint.
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public IPAccessControl Ip { get; set; }

    }
}
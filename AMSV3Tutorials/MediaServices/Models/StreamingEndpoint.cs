// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The StreamingEndpoint.
    /// </summary>
    [JsonTransformation]
    public partial class StreamingEndpoint : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the StreamingEndpoint class.
        /// </summary>
        public StreamingEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StreamingEndpoint class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the
        /// resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="location">The Azure Region of the resource.</param>
        /// <param name="description">The StreamingEndpoint
        /// description.</param>
        /// <param name="scaleUnits">The number of scale units.</param>
        /// <param name="availabilitySetName">AvailabilitySet name</param>
        /// <param name="accessControl">The access control definition of the
        /// StreamingEndpoint.</param>
        /// <param name="maxCacheAge">Max cache age</param>
        /// <param name="customHostNames">The custom host names of the
        /// StreamingEndpoint</param>
        /// <param name="hostName">The StreamingEndpoint host name.</param>
        /// <param name="cdnEnabled">The CDN enabled flag.</param>
        /// <param name="cdnProvider">The CDN provider name.</param>
        /// <param name="cdnProfile">The CDN profile name.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// StreamingEndpoint.</param>
        /// <param name="resourceState">The resource state of the
        /// StreamingEndpoint. Possible values include: 'Stopped', 'Starting',
        /// 'Running', 'Stopping', 'Deleting', 'Scaling'</param>
        /// <param name="crossSiteAccessPolicies">The StreamingEndpoint access
        /// policies.</param>
        /// <param name="freeTrialEndTime">The free trial expiration
        /// time.</param>
        /// <param name="created">The exact time the StreamingEndpoint was
        /// created.</param>
        /// <param name="lastModified">The exact time the StreamingEndpoint was
        /// last modified.</param>
        public StreamingEndpoint(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string location = default(string), string description = default(string), int? scaleUnits = default(int?), string availabilitySetName = default(string), StreamingEndpointAccessControl accessControl = default(StreamingEndpointAccessControl), long? maxCacheAge = default(long?), IList<string> customHostNames = default(IList<string>), string hostName = default(string), bool? cdnEnabled = default(bool?), string cdnProvider = default(string), string cdnProfile = default(string), string provisioningState = default(string), StreamingEndpointResourceState? resourceState = default(StreamingEndpointResourceState?), CrossSiteAccessPolicies crossSiteAccessPolicies = default(CrossSiteAccessPolicies), System.DateTimeOffset? freeTrialEndTime = default(System.DateTimeOffset?), System.DateTimeOffset? created = default(System.DateTimeOffset?), System.DateTimeOffset? lastModified = default(System.DateTimeOffset?))
            : base(id, name, type, tags, location)
        {
            Description = description;
            ScaleUnits = scaleUnits;
            AvailabilitySetName = availabilitySetName;
            AccessControl = accessControl;
            MaxCacheAge = maxCacheAge;
            CustomHostNames = customHostNames;
            HostName = hostName;
            CdnEnabled = cdnEnabled;
            CdnProvider = cdnProvider;
            CdnProfile = cdnProfile;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
            CrossSiteAccessPolicies = crossSiteAccessPolicies;
            FreeTrialEndTime = freeTrialEndTime;
            Created = created;
            LastModified = lastModified;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the StreamingEndpoint description.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the number of scale units.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scaleUnits")]
        public int? ScaleUnits { get; set; }

        /// <summary>
        /// Gets or sets availabilitySet name
        /// </summary>
        [JsonProperty(PropertyName = "properties.availabilitySetName")]
        public string AvailabilitySetName { get; set; }

        /// <summary>
        /// Gets or sets the access control definition of the
        /// StreamingEndpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessControl")]
        public StreamingEndpointAccessControl AccessControl { get; set; }

        /// <summary>
        /// Gets or sets max cache age
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxCacheAge")]
        public long? MaxCacheAge { get; set; }

        /// <summary>
        /// Gets or sets the custom host names of the StreamingEndpoint
        /// </summary>
        [JsonProperty(PropertyName = "properties.customHostNames")]
        public IList<string> CustomHostNames { get; set; }

        /// <summary>
        /// Gets the StreamingEndpoint host name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; private set; }

        /// <summary>
        /// Gets or sets the CDN enabled flag.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cdnEnabled")]
        public bool? CdnEnabled { get; set; }

        /// <summary>
        /// Gets or sets the CDN provider name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cdnProvider")]
        public string CdnProvider { get; set; }

        /// <summary>
        /// Gets or sets the CDN profile name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cdnProfile")]
        public string CdnProfile { get; set; }

        /// <summary>
        /// Gets the provisioning state of the StreamingEndpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the resource state of the StreamingEndpoint. Possible values
        /// include: 'Stopped', 'Starting', 'Running', 'Stopping', 'Deleting',
        /// 'Scaling'
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public StreamingEndpointResourceState? ResourceState { get; private set; }

        /// <summary>
        /// Gets or sets the StreamingEndpoint access policies.
        /// </summary>
        [JsonProperty(PropertyName = "properties.crossSiteAccessPolicies")]
        public CrossSiteAccessPolicies CrossSiteAccessPolicies { get; set; }

        /// <summary>
        /// Gets the free trial expiration time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.freeTrialEndTime")]
        public System.DateTimeOffset? FreeTrialEndTime { get; private set; }

        /// <summary>
        /// Gets the exact time the StreamingEndpoint was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public System.DateTimeOffset? Created { get; private set; }

        /// <summary>
        /// Gets the exact time the StreamingEndpoint was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModified")]
        public System.DateTimeOffset? LastModified { get; private set; }

    }
}

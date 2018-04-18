// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class to specify configurations of FairPlay in Streaming Policy
    /// </summary>
    public partial class StreamingPolicyFairPlayConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// StreamingPolicyFairPlayConfiguration class.
        /// </summary>
        public StreamingPolicyFairPlayConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// StreamingPolicyFairPlayConfiguration class.
        /// </summary>
        /// <param name="allowPersistentLicense">All license to be persistent
        /// or not</param>
        /// <param name="customLicenseAcquisitionUrlTemplate">The template for
        /// a customer service to deliver keys to end users.  Not needed if
        /// using the built in Key Delivery service.</param>
        public StreamingPolicyFairPlayConfiguration(bool allowPersistentLicense, string customLicenseAcquisitionUrlTemplate = default(string))
        {
            CustomLicenseAcquisitionUrlTemplate = customLicenseAcquisitionUrlTemplate;
            AllowPersistentLicense = allowPersistentLicense;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the template for a customer service to deliver keys to
        /// end users.  Not needed if using the built in Key Delivery service.
        /// </summary>
        [JsonProperty(PropertyName = "customLicenseAcquisitionUrlTemplate")]
        public string CustomLicenseAcquisitionUrlTemplate { get; set; }

        /// <summary>
        /// Gets or sets all license to be persistent or not
        /// </summary>
        [JsonProperty(PropertyName = "allowPersistentLicense")]
        public bool AllowPersistentLicense { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
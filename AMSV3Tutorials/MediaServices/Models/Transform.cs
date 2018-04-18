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
    /// A Media Transform that can be applied to an input by creating Jobs.
    /// </summary>
    [JsonTransformation]
    public partial class Transform : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Transform class.
        /// </summary>
        public Transform()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Transform class.
        /// </summary>
        /// <param name="outputs">The outputs for the Transform.</param>
        /// <param name="id">Fully qualified resource ID for the
        /// resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="created">The date and time when the Transform was
        /// created.</param>
        /// <param name="description">Customer supplied description of the
        /// transform.</param>
        /// <param name="lastModified">The date and time when the Transform was
        /// last updated.</param>
        public Transform(IList<TransformOutput> outputs, string id = default(string), string name = default(string), string type = default(string), System.DateTimeOffset created = default(System.DateTimeOffset), string description = default(string), System.DateTimeOffset lastModified = default(System.DateTimeOffset))
            : base(id, name, type)
        {
            Created = created;
            Description = description;
            LastModified = lastModified;
            Outputs = outputs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the date and time when the Transform was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public System.DateTimeOffset Created { get; private set; }

        /// <summary>
        /// Gets or sets customer supplied description of the transform.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the date and time when the Transform was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModified")]
        public System.DateTimeOffset LastModified { get; private set; }

        /// <summary>
        /// Gets or sets the outputs for the Transform.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputs")]
        public IList<TransformOutput> Outputs { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Outputs == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Outputs");
            }
            if (Outputs != null)
            {
                foreach (var element in Outputs)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}

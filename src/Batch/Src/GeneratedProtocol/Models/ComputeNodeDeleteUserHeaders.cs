// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Defines headers for DeleteUser operation.
    /// </summary>
    public partial class ComputeNodeDeleteUserHeaders
    {
        /// <summary>
        /// Initializes a new instance of the ComputeNodeDeleteUserHeaders
        /// class.
        /// </summary>
        public ComputeNodeDeleteUserHeaders() { }

        /// <summary>
        /// Initializes a new instance of the ComputeNodeDeleteUserHeaders
        /// class.
        /// </summary>
        public ComputeNodeDeleteUserHeaders(string clientRequestId = default(string), string requestId = default(string))
        {
            ClientRequestId = clientRequestId;
            RequestId = requestId;
        }

        /// <summary>
        /// Gets the ClientRequestId provided by the client during the
        /// request, if present and requested to be returned.
        /// </summary>
        [JsonProperty(PropertyName = "client-request-id")]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Gets the value that uniquely identifies a request.
        /// </summary>
        [JsonProperty(PropertyName = "request-id")]
        public string RequestId { get; set; }

    }
}

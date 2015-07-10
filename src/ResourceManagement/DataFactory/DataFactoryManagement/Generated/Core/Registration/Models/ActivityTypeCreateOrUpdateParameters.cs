// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.DataFactories.Core.Registration.Models;

namespace Microsoft.Azure.Management.DataFactories.Core.Registration.Models
{
    /// <summary>
    /// Parameters specifying the ActivityType definition for a create or
    /// update operation.
    /// </summary>
    public partial class ActivityTypeCreateOrUpdateParameters
    {
        private ActivityType _activityType;
        
        /// <summary>
        /// Required. The definition of an ActivityType to be created or
        /// updated.
        /// </summary>
        public ActivityType ActivityType
        {
            get { return this._activityType; }
            set { this._activityType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ActivityTypeCreateOrUpdateParameters class.
        /// </summary>
        public ActivityTypeCreateOrUpdateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// ActivityTypeCreateOrUpdateParameters class with required arguments.
        /// </summary>
        public ActivityTypeCreateOrUpdateParameters(ActivityType activityType)
            : this()
        {
            if (activityType == null)
            {
                throw new ArgumentNullException("activityType");
            }
            this.ActivityType = activityType;
        }
    }
}
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
using Microsoft.Azure.Management.DataFactories.Models;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// The create or update hub operation response.
    /// </summary>
    public partial class HubCreateOrUpdateResponse : OperationResponse
    {
        private Hub _hub;
        
        /// <summary>
        /// Optional. The hub instance.
        /// </summary>
        public Hub Hub
        {
            get { return this._hub; }
            set { this._hub = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// Optional. The location url for the get request.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private OperationStatus _status;
        
        /// <summary>
        /// Optional. Status of the operation.
        /// </summary>
        public OperationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the HubCreateOrUpdateResponse class.
        /// </summary>
        public HubCreateOrUpdateResponse()
        {
        }
    }
}

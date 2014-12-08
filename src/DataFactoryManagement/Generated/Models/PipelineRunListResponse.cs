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
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.DataFactories.Models;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// The GetRuns pipeline operation response.
    /// </summary>
    public partial class PipelineRunListResponse : OperationResponse
    {
        private string _nextLink;
        
        /// <summary>
        /// Required. The link (url) to the next page of results.
        /// </summary>
        public string NextLink
        {
            get { return this._nextLink; }
            set { this._nextLink = value; }
        }
        
        private IList<DataSliceRun> _pipelineRuns;
        
        /// <summary>
        /// Optional. A list of the returned runs.
        /// </summary>
        public IList<DataSliceRun> PipelineRuns
        {
            get { return this._pipelineRuns; }
            set { this._pipelineRuns = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the PipelineRunListResponse class.
        /// </summary>
        public PipelineRunListResponse()
        {
            this.PipelineRuns = new LazyList<DataSliceRun>();
        }
        
        /// <summary>
        /// Initializes a new instance of the PipelineRunListResponse class
        /// with required arguments.
        /// </summary>
        public PipelineRunListResponse(string nextLink)
            : this()
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException("nextLink");
            }
            this.NextLink = nextLink;
        }
    }
}

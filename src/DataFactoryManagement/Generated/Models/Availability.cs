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

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// The scheduler definition.
    /// </summary>
    public partial class Availability
    {
        private System.DateTime? _anchorDateTime;
        
        /// <summary>
        /// Optional. The date used as a reference point for calculating slice
        /// start and end dates.
        /// </summary>
        public System.DateTime? AnchorDateTime
        {
            get { return this._anchorDateTime; }
            set { this._anchorDateTime = value; }
        }
        
        private string _frequency;
        
        /// <summary>
        /// Required. Frequency in terms of minute, hour, day, etc.
        /// </summary>
        public string Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }
        
        private uint _interval;
        
        /// <summary>
        /// Required. The interval of running the scheduler.
        /// </summary>
        public uint Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }
        
        private System.TimeSpan? _offset;
        
        /// <summary>
        /// Optional. The offset relative to the anchor time.
        /// </summary>
        public System.TimeSpan? Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }
        
        private string _style;
        
        /// <summary>
        /// Optional. The scheduler style.
        /// </summary>
        public string Style
        {
            get { return this._style; }
            set { this._style = value; }
        }
        
        private WaitOnExternal _waitOnExternal;
        
        /// <summary>
        /// Optional. Wait on external.
        /// </summary>
        public WaitOnExternal WaitOnExternal
        {
            get { return this._waitOnExternal; }
            set { this._waitOnExternal = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Availability class.
        /// </summary>
        public Availability()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the Availability class with required
        /// arguments.
        /// </summary>
        public Availability(string frequency, uint interval)
            : this()
        {
            if (frequency == null)
            {
                throw new ArgumentNullException("frequency");
            }
            this.Frequency = frequency;
            this.Interval = interval;
        }
    }
}

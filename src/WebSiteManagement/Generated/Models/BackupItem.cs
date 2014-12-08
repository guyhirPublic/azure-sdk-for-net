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
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure.Management.WebSites.Models
{
    /// <summary>
    /// A specific backup.
    /// </summary>
    public partial class BackupItem
    {
        private string _blobName;
        
        /// <summary>
        /// Optional. The blob name where the backup is stored, e.g.
        /// mysite1_20140506.zip
        /// </summary>
        public string BlobName
        {
            get { return this._blobName; }
            set { this._blobName = value; }
        }
        
        private string _correlationId;
        
        /// <summary>
        /// Optional. Internal correlation identifier - identifies a specific
        /// backup.
        /// </summary>
        public string CorrelationId
        {
            get { return this._correlationId; }
            set { this._correlationId = value; }
        }
        
        private System.DateTime? _created;
        
        /// <summary>
        /// Optional. Timestamp when the backup has been created.
        /// </summary>
        public System.DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }
        
        private IList<DatabaseBackupSetting> _databases;
        
        /// <summary>
        /// Optional. Database settings for backup.
        /// </summary>
        public IList<DatabaseBackupSetting> Databases
        {
            get { return this._databases; }
            set { this._databases = value; }
        }
        
        private System.DateTime? _finishedTimeStamp;
        
        /// <summary>
        /// Optional. Timestamp when this backup has been finished and a zip
        /// file has been uploaded to a storage account.
        /// </summary>
        public System.DateTime? FinishedTimeStamp
        {
            get { return this._finishedTimeStamp; }
            set { this._finishedTimeStamp = value; }
        }
        
        private System.DateTime? _lastRestoreTimeStamp;
        
        /// <summary>
        /// Optional. Timestamp when this backup has been used for a restore
        /// operation (empty if it wasn't).
        /// </summary>
        public System.DateTime? LastRestoreTimeStamp
        {
            get { return this._lastRestoreTimeStamp; }
            set { this._lastRestoreTimeStamp = value; }
        }
        
        private string _log;
        
        /// <summary>
        /// Optional. Information about the backup, usually used only if there
        /// was an error.
        /// </summary>
        public string Log
        {
            get { return this._log; }
            set { this._log = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. The name of this backup.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private bool _scheduled;
        
        /// <summary>
        /// Optional. True if this backup has been created as a part of a
        /// scheduled backup; false otherwise.
        /// </summary>
        public bool Scheduled
        {
            get { return this._scheduled; }
            set { this._scheduled = value; }
        }
        
        private long _sizeInBytes;
        
        /// <summary>
        /// Optional. Size of the backup zip file in bytes.
        /// </summary>
        public long SizeInBytes
        {
            get { return this._sizeInBytes; }
            set { this._sizeInBytes = value; }
        }
        
        private BackupItemStatus _status;
        
        /// <summary>
        /// Optional. The status of the backup - e.g. Succeeded or Failed
        /// </summary>
        public BackupItemStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _storageAccountUrl;
        
        /// <summary>
        /// Optional. SAS URL for a container in a storage account. E.g.
        /// https://NAME.blob.core.windows.net/CONTAINERNAME/?sv=2012-02-12&st=2013-12-05T19%3A30%3A45Z&se=2017-12-04T19%3A30%3A45Z&sr=c&sp=rwdl&sig=abcdefABCDEFabcdef0123456789
        /// </summary>
        public string StorageAccountUrl
        {
            get { return this._storageAccountUrl; }
            set { this._storageAccountUrl = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BackupItem class.
        /// </summary>
        public BackupItem()
        {
            this.Databases = new LazyList<DatabaseBackupSetting>();
        }
    }
}

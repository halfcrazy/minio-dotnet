﻿/*
 * Minimal Object Storage Library, (C) 2015 Minio, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minio.Client
{
    public class ObjectStat
    {
        public ObjectStat(string key, UInt64 size, DateTime lastModified, string etag) {
            this.Key = key;
            this.Size = size;
            this.LastModified = lastModified;
            this.ETag = etag;
        }
        public string Key { get; private set; }
        public UInt64 Size { get; private set; }
        public DateTime LastModified { get; private set;  }
        public string ETag { get; private set; }
    }
}

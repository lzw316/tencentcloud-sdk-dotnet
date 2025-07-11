/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateReplicationInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 主实例iD
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// 复制实例地域ID
        /// </summary>
        [JsonProperty("ReplicationRegionId")]
        public ulong? ReplicationRegionId{ get; set; }

        /// <summary>
        /// 复制实例地域名称
        /// </summary>
        [JsonProperty("ReplicationRegionName")]
        public string ReplicationRegionName{ get; set; }

        /// <summary>
        /// 是否同步TCR云标签至生成的COS Bucket
        /// </summary>
        [JsonProperty("SyncTag")]
        public bool? SyncTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "ReplicationRegionId", this.ReplicationRegionId);
            this.SetParamSimple(map, prefix + "ReplicationRegionName", this.ReplicationRegionName);
            this.SetParamSimple(map, prefix + "SyncTag", this.SyncTag);
        }
    }
}


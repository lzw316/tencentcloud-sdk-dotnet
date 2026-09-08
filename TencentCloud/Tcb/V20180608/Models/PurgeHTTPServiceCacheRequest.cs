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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PurgeHTTPServiceCacheRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>环境ID</p>
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// <p>HTTPService域名</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>Targets</p><p>参数格式：Targets 刷新目标列表，语义随 PurgeType 变化</p><p>入参限制：单次请求最多传 20 个 Target，单条 URL/prefix/host 最长 2048</p>
        /// </summary>
        [JsonProperty("Targets")]
        public string[] Targets{ get; set; }

        /// <summary>
        /// <p>需要刷新的缓存类型：CDN 或 EO</p><p>枚举值：</p><ul><li>EO： EO缓存</li><li>CDN： CDN缓存</li></ul><p>默认值：EO</p>
        /// </summary>
        [JsonProperty("CacheType")]
        public string CacheType{ get; set; }

        /// <summary>
        /// <p>PurgeType 刷新方式（purge 粒度），TCBCDN仅支持purge_url</p><p>枚举值：</p><ul><li>PURGE_URL： URL 列表（需含协议，如 https://a.com/b.jpg）</li><li>PURGE_PREFIX： URL 前缀列表（需含协议，如 https://a.com/dir/），仅EO支持</li><li>PURGE_HOST： Hostname 列表（可为 host 或 http(s)://host），仅EO支持</li></ul><p>默认值：PURGE_URL</p>
        /// </summary>
        [JsonProperty("PurgeType")]
        public string PurgeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "Targets.", this.Targets);
            this.SetParamSimple(map, prefix + "CacheType", this.CacheType);
            this.SetParamSimple(map, prefix + "PurgeType", this.PurgeType);
        }
    }
}


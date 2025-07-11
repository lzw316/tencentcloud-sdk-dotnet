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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QuotaEntity : AbstractModel
    {
        
        /// <summary>
        /// 已使用配额
        /// </summary>
        [JsonProperty("UsedQuota")]
        public long? UsedQuota{ get; set; }

        /// <summary>
        /// 剩余配额
        /// </summary>
        [JsonProperty("RemainingQuota")]
        public long? RemainingQuota{ get; set; }

        /// <summary>
        /// 总配额
        /// </summary>
        [JsonProperty("TotalQuota")]
        public long? TotalQuota{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UsedQuota", this.UsedQuota);
            this.SetParamSimple(map, prefix + "RemainingQuota", this.RemainingQuota);
            this.SetParamSimple(map, prefix + "TotalQuota", this.TotalQuota);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
        }
    }
}


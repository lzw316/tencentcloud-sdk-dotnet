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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceDataReservedSpaceResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>实际保留比例（%，单节点）</p>
        /// </summary>
        [JsonProperty("ReservedRate")]
        public float? ReservedRate{ get; set; }

        /// <summary>
        /// <p>实际保留空间 GB（单节点）</p><p>单位：GB</p>
        /// </summary>
        [JsonProperty("ReservedSpaceGB")]
        public float? ReservedSpaceGB{ get; set; }

        /// <summary>
        /// <p>用户可用空间 GB（单节点）</p><p>单位：GB</p>
        /// </summary>
        [JsonProperty("UsableSpaceGB")]
        public float? UsableSpaceGB{ get; set; }

        /// <summary>
        /// <p>true=旧版本（&lt;21.6.4.0），值取自老参数 tdstore_enter_readonly_threshold；false=新版本</p>
        /// </summary>
        [JsonProperty("IsLegacy")]
        public bool? IsLegacy{ get; set; }

        /// <summary>
        /// <p>内核版本号</p>
        /// </summary>
        [JsonProperty("KernelVersion")]
        public string KernelVersion{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReservedRate", this.ReservedRate);
            this.SetParamSimple(map, prefix + "ReservedSpaceGB", this.ReservedSpaceGB);
            this.SetParamSimple(map, prefix + "UsableSpaceGB", this.UsableSpaceGB);
            this.SetParamSimple(map, prefix + "IsLegacy", this.IsLegacy);
            this.SetParamSimple(map, prefix + "KernelVersion", this.KernelVersion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


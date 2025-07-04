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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSwitchListsResponse : AbstractModel
    {
        
        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// 列表数据
        /// </summary>
        [JsonProperty("Data")]
        public SwitchListsData[] Data{ get; set; }

        /// <summary>
        /// 区域列表
        /// </summary>
        [JsonProperty("AreaLists")]
        public string[] AreaLists{ get; set; }

        /// <summary>
        /// 打开个数
        /// </summary>
        [JsonProperty("OnNum")]
        public ulong? OnNum{ get; set; }

        /// <summary>
        /// 关闭个数
        /// </summary>
        [JsonProperty("OffNum")]
        public ulong? OffNum{ get; set; }

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
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamArraySimple(map, prefix + "AreaLists.", this.AreaLists);
            this.SetParamSimple(map, prefix + "OnNum", this.OnNum);
            this.SetParamSimple(map, prefix + "OffNum", this.OffNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


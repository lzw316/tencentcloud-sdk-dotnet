/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetMultiFlowStatisticRequest : AbstractModel
    {
        
        /// <summary>
        /// 设备id列表，单次最多请求10个设备
        /// </summary>
        [JsonProperty("DeviceIds")]
        public string[] DeviceIds{ get; set; }

        /// <summary>
        /// 1659514436
        /// </summary>
        [JsonProperty("BeginTime")]
        public long? BeginTime{ get; set; }

        /// <summary>
        /// 1659515000
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 统计流量类型（1：上行流量，2：下行流量）
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 统计时间粒度（1：按小时统计，2：按天统计）
        /// </summary>
        [JsonProperty("TimeGranularity")]
        public long? TimeGranularity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DeviceIds.", this.DeviceIds);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TimeGranularity", this.TimeGranularity);
        }
    }
}

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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBinlogsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，格式如：cdb-c1nl9rpv。与云数据库控制台页面中显示的实例 ID 相同。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 偏移量，最小值为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页大小，默认值为20，最小值为1，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// binlog最早开始时间，时间格式：2016-03-17 02:10:37
        /// </summary>
        [JsonProperty("MinStartTime")]
        public string MinStartTime{ get; set; }

        /// <summary>
        /// binlog最晚开始时间，时间格式：2016-03-17 02:10:37
        /// </summary>
        [JsonProperty("MaxStartTime")]
        public string MaxStartTime{ get; set; }

        /// <summary>
        /// 返回binlog列表是否包含MinStartTime起始节点，默认为否
        /// </summary>
        [JsonProperty("ContainsMinStartTime")]
        public bool? ContainsMinStartTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "MinStartTime", this.MinStartTime);
            this.SetParamSimple(map, prefix + "MaxStartTime", this.MaxStartTime);
            this.SetParamSimple(map, prefix + "ContainsMinStartTime", this.ContainsMinStartTime);
        }
    }
}


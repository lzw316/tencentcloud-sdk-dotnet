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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeResourceGraphProductIngestTaskListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>资源图谱id</p>
        /// </summary>
        [JsonProperty("ResourceGraphId")]
        public string ResourceGraphId{ get; set; }

        /// <summary>
        /// <p>过滤条件</p><ul><li>taskId 按照【接入任务id】进行过滤，默认为模糊匹配。类型：String。必选：否 </li><li>product 按照【接入产品】进行过滤，默认为模糊匹配。类型：String。必选：否 </li><li>name 按照【接入任务名称】进行过滤，默认为模糊匹配。类型：String。必选：否 </li><li>status 按照【接入任务状态】进行过滤。类型：int。必选：否 ；0：初始化中；1：已接入；2：接入失败；3：删除中；5：删除失败<br>注意：每次请求的 Filters 的上限为10，Filter.Values 的上限为100。</li></ul>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>分页偏移量，默认 0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>分页单页数量，默认 20，最大 100</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceGraphId", this.ResourceGraphId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}


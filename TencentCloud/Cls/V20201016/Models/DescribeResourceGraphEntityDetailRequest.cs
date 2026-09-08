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

    public class DescribeResourceGraphEntityDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实体 ID</p>
        /// </summary>
        [JsonProperty("EntityId")]
        public string EntityId{ get; set; }

        /// <summary>
        /// <p>资源图谱id</p>
        /// </summary>
        [JsonProperty("ResourceGraphId")]
        public string ResourceGraphId{ get; set; }

        /// <summary>
        /// <p>查询范围-开始时间</p><p>单位：毫秒</p>
        /// </summary>
        [JsonProperty("FromTime")]
        public ulong? FromTime{ get; set; }

        /// <summary>
        /// <p>查询范围-结束时间</p><p>单位：毫秒</p>
        /// </summary>
        [JsonProperty("ToTime")]
        public ulong? ToTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EntityId", this.EntityId);
            this.SetParamSimple(map, prefix + "ResourceGraphId", this.ResourceGraphId);
            this.SetParamSimple(map, prefix + "FromTime", this.FromTime);
            this.SetParamSimple(map, prefix + "ToTime", this.ToTime);
        }
    }
}


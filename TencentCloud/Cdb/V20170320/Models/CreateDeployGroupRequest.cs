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

    public class CreateDeployGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 置放群组名称，最长不能超过60个字符。
        /// </summary>
        [JsonProperty("DeployGroupName")]
        public string DeployGroupName{ get; set; }

        /// <summary>
        /// 置放群组描述，最长不能超过200个字符。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 置放群组的亲和性策略，目前仅支持取值为1，策略1表示同台物理机上限制实例的个数。
        /// </summary>
        [JsonProperty("Affinity")]
        public long?[] Affinity{ get; set; }

        /// <summary>
        /// 置放群组亲和性策略1中同台物理机上实例的限制个数。
        /// </summary>
        [JsonProperty("LimitNum")]
        public long? LimitNum{ get; set; }

        /// <summary>
        /// 置放群组机型属性，可选参数：SH12+SH02、TS85。
        /// </summary>
        [JsonProperty("DevClass")]
        public string[] DevClass{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeployGroupName", this.DeployGroupName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "Affinity.", this.Affinity);
            this.SetParamSimple(map, prefix + "LimitNum", this.LimitNum);
            this.SetParamArraySimple(map, prefix + "DevClass.", this.DevClass);
        }
    }
}


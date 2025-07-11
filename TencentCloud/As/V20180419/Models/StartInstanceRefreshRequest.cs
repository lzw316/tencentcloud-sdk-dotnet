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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartInstanceRefreshRequest : AbstractModel
    {
        
        /// <summary>
        /// 伸缩组ID。
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 刷新设置。
        /// </summary>
        [JsonProperty("RefreshSettings")]
        public RefreshSettings RefreshSettings{ get; set; }

        /// <summary>
        /// 刷新模式。默认值为 ROLLING_UPDATE_RESET，取值范围：
        /// <li>ROLLING_UPDATE_RESET：重装系统进行滚动更新</li>
        /// <li>ROLLING_UPDATE_REPLACE：新建实例替换进行滚动更新，该模式暂不支持回滚接口</li>
        /// </summary>
        [JsonProperty("RefreshMode")]
        public string RefreshMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamObj(map, prefix + "RefreshSettings.", this.RefreshSettings);
            this.SetParamSimple(map, prefix + "RefreshMode", this.RefreshMode);
        }
    }
}


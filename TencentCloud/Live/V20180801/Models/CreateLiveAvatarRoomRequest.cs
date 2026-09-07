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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLiveAvatarRoomRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>直播间名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>操作者。</p>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// <p>形象ID</p>
        /// </summary>
        [JsonProperty("AvatarKey")]
        public string AvatarKey{ get; set; }

        /// <summary>
        /// <p>音色ID</p>
        /// </summary>
        [JsonProperty("TimbreKey")]
        public string TimbreKey{ get; set; }

        /// <summary>
        /// <p>房间模式</p><p>枚举值：</p><ul><li>INTERACT： 交互模式</li><li>FREE： 自由模式</li><li>NORMAL： 普通模式</li></ul>
        /// </summary>
        [JsonProperty("LiveMode")]
        public string LiveMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "AvatarKey", this.AvatarKey);
            this.SetParamSimple(map, prefix + "TimbreKey", this.TimbreKey);
            this.SetParamSimple(map, prefix + "LiveMode", this.LiveMode);
        }
    }
}


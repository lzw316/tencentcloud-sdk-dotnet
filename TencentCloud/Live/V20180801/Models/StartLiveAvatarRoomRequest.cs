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

    public class StartLiveAvatarRoomRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>数字人直播间 ID。</p>
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// <p>目标地址描述。</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>推流目标地址。</p>
        /// </summary>
        [JsonProperty("ToUrl")]
        public string ToUrl{ get; set; }

        /// <summary>
        /// <p>操作者。</p>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// <p>房间类型。AIGC：AIGC形象房间；PRESET：预设形象房间</p><p>枚举值：</p><ul><li>AIGC： AIGC形象房间</li><li>PRESET： 预设形象房间</li></ul>
        /// </summary>
        [JsonProperty("RoomType")]
        public string RoomType{ get; set; }

        /// <summary>
        /// <p>交互模式下的协议，支持rtmp和trtc，默认是rtmp</p>
        /// </summary>
        [JsonProperty("SessionProtocol")]
        public string SessionProtocol{ get; set; }

        /// <summary>
        /// <p>使用trtc协议时，在trtc的appid</p>
        /// </summary>
        [JsonProperty("TrtcSdkAppId")]
        public string TrtcSdkAppId{ get; set; }

        /// <summary>
        /// <p>进入房间时需要用UserSign来校验权限</p>
        /// </summary>
        [JsonProperty("TrtcUserSig")]
        public string TrtcUserSig{ get; set; }

        /// <summary>
        /// <p>要进入的房间</p>
        /// </summary>
        [JsonProperty("TrtcRoomId")]
        public string TrtcRoomId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "ToUrl", this.ToUrl);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "RoomType", this.RoomType);
            this.SetParamSimple(map, prefix + "SessionProtocol", this.SessionProtocol);
            this.SetParamSimple(map, prefix + "TrtcSdkAppId", this.TrtcSdkAppId);
            this.SetParamSimple(map, prefix + "TrtcUserSig", this.TrtcUserSig);
            this.SetParamSimple(map, prefix + "TrtcRoomId", this.TrtcRoomId);
        }
    }
}


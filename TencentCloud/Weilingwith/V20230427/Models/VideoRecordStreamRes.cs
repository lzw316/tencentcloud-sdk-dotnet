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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoRecordStreamRes : AbstractModel
    {
        
        /// <summary>
        /// FLV协议格式视频流
        /// </summary>
        [JsonProperty("FLV")]
        public string FLV{ get; set; }

        /// <summary>
        /// RTMP协议格式视频流
        /// </summary>
        [JsonProperty("RTMP")]
        public string RTMP{ get; set; }

        /// <summary>
        /// HLS协议格式视频流
        /// </summary>
        [JsonProperty("HLS")]
        public string HLS{ get; set; }

        /// <summary>
        /// WebRtc协议格式视频流
        /// </summary>
        [JsonProperty("WebRTC")]
        public string WebRTC{ get; set; }

        /// <summary>
        /// RAW协议格式视频流
        /// </summary>
        [JsonProperty("RAW")]
        public RawInfo RAW{ get; set; }

        /// <summary>
        /// 视频流的唯一标识
        /// </summary>
        [JsonProperty("Stream")]
        public string Stream{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FLV", this.FLV);
            this.SetParamSimple(map, prefix + "RTMP", this.RTMP);
            this.SetParamSimple(map, prefix + "HLS", this.HLS);
            this.SetParamSimple(map, prefix + "WebRTC", this.WebRTC);
            this.SetParamObj(map, prefix + "RAW.", this.RAW);
            this.SetParamSimple(map, prefix + "Stream", this.Stream);
        }
    }
}


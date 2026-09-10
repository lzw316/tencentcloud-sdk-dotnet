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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DubbingOutputConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>输出方式</p><p>枚举值：</p><ul><li>FinalVideoOnly： 默认，仅成片视频</li><li>AudioAndSubtitle： 译文音频+译文字幕</li><li>Custom： 自定义</li></ul><p>默认值：FinalVideoOnly</p><p>使用外部字幕时无译文音频+字幕返回</p>
        /// </summary>
        [JsonProperty("OutputMode")]
        public string OutputMode{ get; set; }

        /// <summary>
        /// <p>输出成片视频开关</p><p>枚举值：</p><ul><li>ON： 打开</li><li>OFF： 关闭</li></ul><p>默认值：ON</p><p>仅 Custom 模式生效</p>
        /// </summary>
        [JsonProperty("OutputFinalVideo")]
        public string OutputFinalVideo{ get; set; }

        /// <summary>
        /// <p>输出字幕文件（同时包含原语音字幕、目标语言字幕）开关</p><p>枚举值：</p><ul><li>ON： 开启</li><li>OFF： 关闭</li></ul><p>默认值：OFF</p>
        /// </summary>
        [JsonProperty("OutputSubtitle")]
        public string OutputSubtitle{ get; set; }

        /// <summary>
        /// <p>输出译文配音音频开关</p><p>枚举值：</p><ul><li>ON： 开启</li><li>OFF： 关闭</li></ul><p>默认值：OFF</p><p>仅 Custom 模式生效</p>
        /// </summary>
        [JsonProperty("OutputDstAudio")]
        public string OutputDstAudio{ get; set; }

        /// <summary>
        /// <p>压制字幕配置信息。</p>
        /// </summary>
        [JsonProperty("EmbedSubtitleConfig")]
        public DubbingEmbedSubtitleConfig EmbedSubtitleConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutputMode", this.OutputMode);
            this.SetParamSimple(map, prefix + "OutputFinalVideo", this.OutputFinalVideo);
            this.SetParamSimple(map, prefix + "OutputSubtitle", this.OutputSubtitle);
            this.SetParamSimple(map, prefix + "OutputDstAudio", this.OutputDstAudio);
            this.SetParamObj(map, prefix + "EmbedSubtitleConfig.", this.EmbedSubtitleConfig);
        }
    }
}


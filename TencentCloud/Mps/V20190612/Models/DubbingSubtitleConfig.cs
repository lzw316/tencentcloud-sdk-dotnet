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

    public class DubbingSubtitleConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>字幕来源。</p><p>枚举值：</p><ul><li>OCR： OCR文本识别，识别视频画面上的文本。</li><li>ASR： ASR语音识别，识别视频语音对话。</li><li>External： 外部字幕文件，提供原文/译文字幕URL。</li></ul>
        /// </summary>
        [JsonProperty("SubtitleSource")]
        public string SubtitleSource{ get; set; }

        /// <summary>
        /// <p>使用ASR辅助OCR。</p><p>枚举值：</p><ul><li>ON： 开启使用ASR辅助OCR。</li><li>OFF： 不开启使用ASR辅助OCR。</li></ul><p>默认值：OFF</p><p>仅 SubtitleSource=OCR 时允许设为 ON</p>
        /// </summary>
        [JsonProperty("AsrAssistOcr")]
        public string AsrAssistOcr{ get; set; }

        /// <summary>
        /// <p>擦除原字幕。</p><p>枚举值：</p><ul><li>ON： 擦除原字幕。</li><li>OFF： 保留原字幕。</li></ul><p>默认值：OFF</p><p>SubtitleSource=External 时不允许设为 ON</p>
        /// </summary>
        [JsonProperty("EraseOriginalSubtitle")]
        public string EraseOriginalSubtitle{ get; set; }

        /// <summary>
        /// <p>字幕位置信息。</p>
        /// </summary>
        [JsonProperty("SelectingSubtitleAreasConfig")]
        public SelectingSubtitleAreasConfig SelectingSubtitleAreasConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubtitleSource", this.SubtitleSource);
            this.SetParamSimple(map, prefix + "AsrAssistOcr", this.AsrAssistOcr);
            this.SetParamSimple(map, prefix + "EraseOriginalSubtitle", this.EraseOriginalSubtitle);
            this.SetParamObj(map, prefix + "SelectingSubtitleAreasConfig.", this.SelectingSubtitleAreasConfig);
        }
    }
}


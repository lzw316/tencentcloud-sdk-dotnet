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

    public class OverrideAIDubbingParameter : AbstractModel
    {
        
        /// <summary>
        /// <p>翻译配置信息。</p>
        /// </summary>
        [JsonProperty("TranslateConfig")]
        public DubbingTranslateConfig TranslateConfig{ get; set; }

        /// <summary>
        /// <p>字幕配置信息。</p>
        /// </summary>
        [JsonProperty("SubtitleConfig")]
        public DubbingSubtitleConfig SubtitleConfig{ get; set; }

        /// <summary>
        /// <p>配音配置信息。</p>
        /// </summary>
        [JsonProperty("DubbingConfig")]
        public DubbingConfig DubbingConfig{ get; set; }

        /// <summary>
        /// <p>输出配置信息。</p>
        /// </summary>
        [JsonProperty("OutputConfig")]
        public DubbingOutputConfig OutputConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TranslateConfig.", this.TranslateConfig);
            this.SetParamObj(map, prefix + "SubtitleConfig.", this.SubtitleConfig);
            this.SetParamObj(map, prefix + "DubbingConfig.", this.DubbingConfig);
            this.SetParamObj(map, prefix + "OutputConfig.", this.OutputConfig);
        }
    }
}


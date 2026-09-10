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

    public class DubbingConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>配音类型，可选值：FullAutoEmotionClone：全自动高情感克隆配音；RoleBasedSmartDubbing：按角色智能配音；SingleVoice：指定单一音色；</p>
        /// </summary>
        [JsonProperty("DubbingMode")]
        public string DubbingMode{ get; set; }

        /// <summary>
        /// <p>背景音音量，范围0-100</p><p>默认值：80</p>
        /// </summary>
        [JsonProperty("BackgroundVolume")]
        public long? BackgroundVolume{ get; set; }

        /// <summary>
        /// <p>二次微调开关，可选值：<br>ON: 开启二次微调；<br>OFF: 不开启二次微调；</p><p>默认值：OFF</p><p>仅 RoleBasedSmartDubbing 时允许设为 ON</p>
        /// </summary>
        [JsonProperty("SecondaryTuning")]
        public string SecondaryTuning{ get; set; }

        /// <summary>
        /// <p>指定音色</p><p>仅 SingleVoice 时有效且 Create 必填</p>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p>配音版本，可选值：v1，v2</p><p>默认值：v2</p><p>只在（FullAutoEmotionClone：全自动高情感克隆配音）模式下生效</p>
        /// </summary>
        [JsonProperty("DubbingVersion")]
        public string DubbingVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DubbingMode", this.DubbingMode);
            this.SetParamSimple(map, prefix + "BackgroundVolume", this.BackgroundVolume);
            this.SetParamSimple(map, prefix + "SecondaryTuning", this.SecondaryTuning);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamSimple(map, prefix + "DubbingVersion", this.DubbingVersion);
        }
    }
}


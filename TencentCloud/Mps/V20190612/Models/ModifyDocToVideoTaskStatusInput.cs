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

    public class ModifyDocToVideoTaskStatusInput : AbstractModel
    {
        
        /// <summary>
        /// <p>修改动作类型。</p><p>枚举值：</p><ul><li>confirm： 确认已完成阶段并推进下一阶段</li><li>regenerate： 重新生成指定阶段</li></ul>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>修改目标阶段。</p><p>枚举值：</p><ul><li>STAGE_1：<br>Action=confirm 时：确认大纲、继续生成后续配音、动画效果、字幕；<br>Action=regenerate 时：重新生成大纲。</li></ul><ul><li>STAGE_2：<br>Action=confirm 时：确认生成的配音、动画效果、字幕，生成最终成片；<br>Action=regenerate 时：重新生成配音、动画效果、字幕。</li></ul>
        /// </summary>
        [JsonProperty("Stage")]
        public string Stage{ get; set; }

        /// <summary>
        /// <p>需要进行修改的目标任务 ID。</p>
        /// </summary>
        [JsonProperty("SourceTaskId")]
        public string SourceTaskId{ get; set; }

        /// <summary>
        /// <p>重新生成参数。</p><p>仅 Action=regenerate 时必填。</p>
        /// </summary>
        [JsonProperty("Regenerate")]
        public DocToVideoRegenerateInput Regenerate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Stage", this.Stage);
            this.SetParamSimple(map, prefix + "SourceTaskId", this.SourceTaskId);
            this.SetParamObj(map, prefix + "Regenerate.", this.Regenerate);
        }
    }
}


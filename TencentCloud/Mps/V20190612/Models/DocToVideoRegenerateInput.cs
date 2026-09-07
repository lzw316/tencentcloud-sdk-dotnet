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

    public class DocToVideoRegenerateInput : AbstractModel
    {
        
        /// <summary>
        /// <p>重新生成的范围。</p><p>枚举值：</p><ul><li>full： 该阶段全量重新生成（例如：修改整体的场景数量）</li><li>scenes： 按场景局部重新生成（例如：修改某场景的具体内容）</li></ul>
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// <p>重新生成时的提示词。</p>
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// <p>按页局部重新生成时的目标页 ID 数组。仅 Scope=scenes 时必填。不可重复，单次重新生成最多 5 页。</p>
        /// </summary>
        [JsonProperty("SceneIds")]
        public string[] SceneIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamArraySimple(map, prefix + "SceneIds.", this.SceneIds);
        }
    }
}


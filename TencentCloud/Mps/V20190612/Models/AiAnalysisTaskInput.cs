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

    public class AiAnalysisTaskInput : AbstractModel
    {
        
        /// <summary>
        /// 视频内容分析模板 ID。
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// 扩展参数，其值为序列化的 json字符串。
        /// 注意：此参数为定制需求参数，参考如下：
        /// [智能檫除](https://cloud.tencent.com/document/product/862/101530)
        /// [智能拆条](https://cloud.tencent.com/document/product/862/112098)
        /// [高光集锦](https://cloud.tencent.com/document/product/862/107280)
        /// [智能横转竖](https://cloud.tencent.com/document/product/862/112112)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtendedParameter")]
        public string ExtendedParameter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "ExtendedParameter", this.ExtendedParameter);
        }
    }
}


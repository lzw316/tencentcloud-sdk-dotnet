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

    public class BatchSubTaskResult : AbstractModel
    {
        
        /// <summary>
        /// 批量任务输入信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputInfos")]
        public MediaInputInfo[] InputInfos{ get; set; }

        /// <summary>
        /// 原始视频的元信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Metadatas")]
        public MediaMetaData[] Metadatas{ get; set; }

        /// <summary>
        /// 智能字幕任务的执行结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SmartSubtitlesTaskResult")]
        public BatchSmartSubtitlesResult SmartSubtitlesTaskResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "InputInfos.", this.InputInfos);
            this.SetParamArrayObj(map, prefix + "Metadatas.", this.Metadatas);
            this.SetParamObj(map, prefix + "SmartSubtitlesTaskResult.", this.SmartSubtitlesTaskResult);
        }
    }
}


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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DependencyConfigDsDTO : AbstractModel
    {
        
        /// <summary>
        /// ParentTask任务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentTask")]
        public TaskDsDTO ParentTask{ get; set; }

        /// <summary>
        /// SonTask任务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SonTask")]
        public TaskDsDTO SonTask{ get; set; }

        /// <summary>
        /// the dependency config
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MainCyclicConfig")]
        public string MainCyclicConfig{ get; set; }

        /// <summary>
        /// SubordinateCyclicConfig配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubordinateCyclicConfig")]
        public string SubordinateCyclicConfig{ get; set; }

        /// <summary>
        /// DependencyStrategy策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DependencyStrategy")]
        public DependencyStrategyDs DependencyStrategy{ get; set; }

        /// <summary>
        /// 偏移量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ParentTask.", this.ParentTask);
            this.SetParamObj(map, prefix + "SonTask.", this.SonTask);
            this.SetParamSimple(map, prefix + "MainCyclicConfig", this.MainCyclicConfig);
            this.SetParamSimple(map, prefix + "SubordinateCyclicConfig", this.SubordinateCyclicConfig);
            this.SetParamObj(map, prefix + "DependencyStrategy.", this.DependencyStrategy);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}


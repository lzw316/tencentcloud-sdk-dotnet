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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SkillVersion : AbstractModel
    {
        
        /// <summary>
        /// <p>检测信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnalysisInfo")]
        public SkillAnalysisInfo AnalysisInfo{ get; set; }

        /// <summary>
        /// <p>当前生效版本号</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>当前生效版本ID</p>
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// <p>Skill 版本发布流程状态：</p><pre><code>  - 0 INITIALIZED      初始化（版本初始态）  - 1 AUDITING         审核中（f_analysis_status ∈ {PENDING, RUNNING}）  - 2 PENDING_RELEASE  待发布（低/中风险，等用户确认上架）  - 3 RELEASED         已发布  - 4 UNRELEASED       未发布（HIGH / UNAVAILABLE / FAILED / 用户放弃，含历史&quot;不通过&quot;语义）与 SkillAnalysisStatus 解耦：前者是用户视角发布生命周期，后者是安全检测阶段。</code></pre>
        /// </summary>
        [JsonProperty("VersionStatus")]
        public long? VersionStatus{ get; set; }

        /// <summary>
        /// <p>Skill包的md5信息</p>
        /// </summary>
        [JsonProperty("SkillMd5")]
        public string SkillMd5{ get; set; }

        /// <summary>
        /// <p>版本包地址</p>
        /// </summary>
        [JsonProperty("SkillUrl")]
        public string SkillUrl{ get; set; }

        /// <summary>
        /// <p>版本创建时间（Unix秒）</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>skill md文档</p>
        /// </summary>
        [JsonProperty("SkillMarkdownUrl")]
        public string SkillMarkdownUrl{ get; set; }

        /// <summary>
        /// <p>版本变更说明</p>
        /// </summary>
        [JsonProperty("UpdateDesc")]
        public string UpdateDesc{ get; set; }

        /// <summary>
        /// <p>变更用户</p>
        /// </summary>
        [JsonProperty("Updater")]
        public string Updater{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AnalysisInfo.", this.AnalysisInfo);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "VersionStatus", this.VersionStatus);
            this.SetParamSimple(map, prefix + "SkillMd5", this.SkillMd5);
            this.SetParamSimple(map, prefix + "SkillUrl", this.SkillUrl);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SkillMarkdownUrl", this.SkillMarkdownUrl);
            this.SetParamSimple(map, prefix + "UpdateDesc", this.UpdateDesc);
            this.SetParamSimple(map, prefix + "Updater", this.Updater);
        }
    }
}


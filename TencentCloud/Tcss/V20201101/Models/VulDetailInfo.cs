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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// CVE编号
        /// </summary>
        [JsonProperty("CVEID")]
        public string CVEID{ get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 漏洞标签
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 漏洞类型
        /// </summary>
        [JsonProperty("CategoryType")]
        public string CategoryType{ get; set; }

        /// <summary>
        /// 漏洞威胁等级
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 漏洞披露时间
        /// </summary>
        [JsonProperty("SubmitTime")]
        public string SubmitTime{ get; set; }

        /// <summary>
        /// 漏洞描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// CVSS V3描述
        /// </summary>
        [JsonProperty("CVSSV3Desc")]
        public string CVSSV3Desc{ get; set; }

        /// <summary>
        /// 漏洞修复建议
        /// </summary>
        [JsonProperty("OfficialSolution")]
        public string OfficialSolution{ get; set; }

        /// <summary>
        /// 缓解措施
        /// </summary>
        [JsonProperty("DefenseSolution")]
        public string DefenseSolution{ get; set; }

        /// <summary>
        /// 参考链接
        /// </summary>
        [JsonProperty("Reference")]
        public string[] Reference{ get; set; }

        /// <summary>
        /// CVSS V3分数
        /// </summary>
        [JsonProperty("CVSSV3Score")]
        public float? CVSSV3Score{ get; set; }

        /// <summary>
        /// 受漏洞影响的组件列表
        /// </summary>
        [JsonProperty("ComponentList")]
        public VulAffectedComponentInfo[] ComponentList{ get; set; }

        /// <summary>
        /// 影响本地镜像数
        /// </summary>
        [JsonProperty("LocalImageCount")]
        public long? LocalImageCount{ get; set; }

        /// <summary>
        /// 影响容器数
        /// </summary>
        [JsonProperty("ContainerCount")]
        public long? ContainerCount{ get; set; }

        /// <summary>
        /// 影响仓库镜像数
        /// </summary>
        [JsonProperty("RegistryImageCount")]
        public long? RegistryImageCount{ get; set; }

        /// <summary>
        /// 漏洞子类型
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 影响最新本地镜像数
        /// </summary>
        [JsonProperty("LocalNewestImageCount")]
        public long? LocalNewestImageCount{ get; set; }

        /// <summary>
        /// 影响最新仓库镜像数
        /// </summary>
        [JsonProperty("RegistryNewestImageCount")]
        public long? RegistryNewestImageCount{ get; set; }

        /// <summary>
        /// 漏洞PocID
        /// </summary>
        [JsonProperty("PocID")]
        public string PocID{ get; set; }

        /// <summary>
        /// 防御状态，NO_DEFENDED:未防御，DEFENDED:已防御
        /// </summary>
        [JsonProperty("DefenceStatus")]
        public string DefenceStatus{ get; set; }

        /// <summary>
        /// 漏洞防御主机范围: MANUAL:自选主机节点，ALL:全部
        /// </summary>
        [JsonProperty("DefenceScope")]
        public string DefenceScope{ get; set; }

        /// <summary>
        /// 漏洞防御主机数量
        /// </summary>
        [JsonProperty("DefenceHostCount")]
        public long? DefenceHostCount{ get; set; }

        /// <summary>
        /// 已防御攻击次数
        /// </summary>
        [JsonProperty("DefendedCount")]
        public long? DefendedCount{ get; set; }

        /// <summary>
        /// 是否已扫描，NOT_SCAN:未扫描,SCANNED:已扫描
        /// </summary>
        [JsonProperty("ScanStatus")]
        public string ScanStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CVEID", this.CVEID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "CategoryType", this.CategoryType);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "SubmitTime", this.SubmitTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CVSSV3Desc", this.CVSSV3Desc);
            this.SetParamSimple(map, prefix + "OfficialSolution", this.OfficialSolution);
            this.SetParamSimple(map, prefix + "DefenseSolution", this.DefenseSolution);
            this.SetParamArraySimple(map, prefix + "Reference.", this.Reference);
            this.SetParamSimple(map, prefix + "CVSSV3Score", this.CVSSV3Score);
            this.SetParamArrayObj(map, prefix + "ComponentList.", this.ComponentList);
            this.SetParamSimple(map, prefix + "LocalImageCount", this.LocalImageCount);
            this.SetParamSimple(map, prefix + "ContainerCount", this.ContainerCount);
            this.SetParamSimple(map, prefix + "RegistryImageCount", this.RegistryImageCount);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "LocalNewestImageCount", this.LocalNewestImageCount);
            this.SetParamSimple(map, prefix + "RegistryNewestImageCount", this.RegistryNewestImageCount);
            this.SetParamSimple(map, prefix + "PocID", this.PocID);
            this.SetParamSimple(map, prefix + "DefenceStatus", this.DefenceStatus);
            this.SetParamSimple(map, prefix + "DefenceScope", this.DefenceScope);
            this.SetParamSimple(map, prefix + "DefenceHostCount", this.DefenceHostCount);
            this.SetParamSimple(map, prefix + "DefendedCount", this.DefendedCount);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
        }
    }
}


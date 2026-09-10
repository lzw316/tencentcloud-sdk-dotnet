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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataLeakOutAlertEvent : AbstractModel
    {
        
        /// <summary>
        /// 风险ID
        /// </summary>
        [JsonProperty("RiskID")]
        public string RiskID{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 源IP
        /// </summary>
        [JsonProperty("SrcIP")]
        public string SrcIP{ get; set; }

        /// <summary>
        /// 目的IP端口，多个以逗号连接：1.1.1.1:80,1.1.1.1:8080
        /// </summary>
        [JsonProperty("DstIPPort")]
        public string DstIPPort{ get; set; }

        /// <summary>
        /// hostname
        /// </summary>
        [JsonProperty("Hostname")]
        public string Hostname{ get; set; }

        /// <summary>
        /// 目的服务类型
        /// </summary>
        [JsonProperty("DstServiceType")]
        public string DstServiceType{ get; set; }

        /// <summary>
        /// 目的服务名称
        /// </summary>
        [JsonProperty("DstServiceName")]
        public string DstServiceName{ get; set; }

        /// <summary>
        /// 以逗号连接的敏感类型ID集合: 10001,10002,10003
        /// </summary>
        [JsonProperty("LeakTypeSet")]
        public string LeakTypeSet{ get; set; }

        /// <summary>
        /// 事件数量
        /// </summary>
        [JsonProperty("EventCount")]
        public ulong? EventCount{ get; set; }

        /// <summary>
        /// 首次识别时间
        /// </summary>
        [JsonProperty("FirstIdentificationTime")]
        public string FirstIdentificationTime{ get; set; }

        /// <summary>
        /// 最近识别时间
        /// </summary>
        [JsonProperty("LatestIdentificationTime")]
        public string LatestIdentificationTime{ get; set; }

        /// <summary>
        /// 风险等级
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 处置状态
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// API
        /// </summary>
        [JsonProperty("ApiPattern")]
        public string ApiPattern{ get; set; }

        /// <summary>
        /// AI分析状态
        /// </summary>
        [JsonProperty("AnalysisStatus")]
        public ulong? AnalysisStatus{ get; set; }

        /// <summary>
        /// AI分析失败原因（失败时）
        /// </summary>
        [JsonProperty("AnalysisFailReason")]
        public string AnalysisFailReason{ get; set; }

        /// <summary>
        /// API业务类型
        /// </summary>
        [JsonProperty("ApiBizType")]
        public string ApiBizType{ get; set; }

        /// <summary>
        /// 风险类型（风险场景）
        /// </summary>
        [JsonProperty("RiskScenario")]
        public string RiskScenario{ get; set; }

        /// <summary>
        /// AI建议风险等级
        /// </summary>
        [JsonProperty("AiSuggestedLevel")]
        public long? AiSuggestedLevel{ get; set; }

        /// <summary>
        /// 目的IP地理信息
        /// </summary>
        [JsonProperty("DstGeoLocation")]
        public string DstGeoLocation{ get; set; }

        /// <summary>
        /// 最高敏感等级
        /// </summary>
        [JsonProperty("HighestLevel")]
        public string HighestLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskID", this.RiskID);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "SrcIP", this.SrcIP);
            this.SetParamSimple(map, prefix + "DstIPPort", this.DstIPPort);
            this.SetParamSimple(map, prefix + "Hostname", this.Hostname);
            this.SetParamSimple(map, prefix + "DstServiceType", this.DstServiceType);
            this.SetParamSimple(map, prefix + "DstServiceName", this.DstServiceName);
            this.SetParamSimple(map, prefix + "LeakTypeSet", this.LeakTypeSet);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "FirstIdentificationTime", this.FirstIdentificationTime);
            this.SetParamSimple(map, prefix + "LatestIdentificationTime", this.LatestIdentificationTime);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "ApiPattern", this.ApiPattern);
            this.SetParamSimple(map, prefix + "AnalysisStatus", this.AnalysisStatus);
            this.SetParamSimple(map, prefix + "AnalysisFailReason", this.AnalysisFailReason);
            this.SetParamSimple(map, prefix + "ApiBizType", this.ApiBizType);
            this.SetParamSimple(map, prefix + "RiskScenario", this.RiskScenario);
            this.SetParamSimple(map, prefix + "AiSuggestedLevel", this.AiSuggestedLevel);
            this.SetParamSimple(map, prefix + "DstGeoLocation", this.DstGeoLocation);
            this.SetParamSimple(map, prefix + "HighestLevel", this.HighestLevel);
        }
    }
}


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

namespace TencentCloud.Vcube.V20220410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class XMagicFeature : AbstractModel
    {
        
        /// <summary>
        /// 功能名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 可以申请的次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TrialCount")]
        public ulong? TrialCount{ get; set; }

        /// <summary>
        /// 每次申请的时长单位：天
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// 功能类别
        /// </summary>
        [JsonProperty("Plan")]
        public string Plan{ get; set; }

        /// <summary>
        /// single: 原子能力,combined:套餐
        /// </summary>
        [JsonProperty("XMagicType")]
        public string XMagicType{ get; set; }

        /// <summary>
        /// 此功能是否支持开通测试
        /// </summary>
        [JsonProperty("Trial")]
        public bool? Trial{ get; set; }

        /// <summary>
        /// 功能所属业务方
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TrialCount", this.TrialCount);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Plan", this.Plan);
            this.SetParamSimple(map, prefix + "XMagicType", this.XMagicType);
            this.SetParamSimple(map, prefix + "Trial", this.Trial);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
        }
    }
}


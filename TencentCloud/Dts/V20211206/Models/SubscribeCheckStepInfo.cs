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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubscribeCheckStepInfo : AbstractModel
    {
        
        /// <summary>
        /// 步骤名称
        /// </summary>
        [JsonProperty("StepName")]
        public string StepName{ get; set; }

        /// <summary>
        /// 步骤Id
        /// </summary>
        [JsonProperty("StepId")]
        public string StepId{ get; set; }

        /// <summary>
        /// 步骤编号，从 1 开始
        /// </summary>
        [JsonProperty("StepNo")]
        public ulong? StepNo{ get; set; }

        /// <summary>
        /// 当前步骤状态，可能值为 notStarted,running,finished,failed
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 当前步骤进度
        /// </summary>
        [JsonProperty("Percent")]
        public ulong? Percent{ get; set; }

        /// <summary>
        /// 错误提示
        /// </summary>
        [JsonProperty("Errors")]
        public SubscribeCheckStepTip[] Errors{ get; set; }

        /// <summary>
        /// 告警提示
        /// </summary>
        [JsonProperty("Warnings")]
        public SubscribeCheckStepTip[] Warnings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StepName", this.StepName);
            this.SetParamSimple(map, prefix + "StepId", this.StepId);
            this.SetParamSimple(map, prefix + "StepNo", this.StepNo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamArrayObj(map, prefix + "Errors.", this.Errors);
            this.SetParamArrayObj(map, prefix + "Warnings.", this.Warnings);
        }
    }
}


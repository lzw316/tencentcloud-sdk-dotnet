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

    public class ModifyCompareTaskNameRequest : AbstractModel
    {
        
        /// <summary>
        /// 迁移任务 Id
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 对比任务 ID，形如：dts-8yv4w2i1-cmp-37skmii9
        /// </summary>
        [JsonProperty("CompareTaskId")]
        public string CompareTaskId{ get; set; }

        /// <summary>
        /// 一致性校验任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "CompareTaskId", this.CompareTaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
        }
    }
}


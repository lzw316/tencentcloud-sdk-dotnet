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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskGroupForAction : AbstractModel
    {
        
        /// <summary>
        /// 动作ID
        /// </summary>
        [JsonProperty("TaskActionId")]
        public long? TaskActionId{ get; set; }

        /// <summary>
        /// {"ActionTimeout":1800}
        /// </summary>
        [JsonProperty("TaskActionGeneralConfiguration")]
        public string TaskActionGeneralConfiguration{ get; set; }

        /// <summary>
        /// {"ip": "0.0.0.0"}
        /// </summary>
        [JsonProperty("TaskActionCustomConfiguration")]
        public string TaskActionCustomConfiguration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskActionId", this.TaskActionId);
            this.SetParamSimple(map, prefix + "TaskActionGeneralConfiguration", this.TaskActionGeneralConfiguration);
            this.SetParamSimple(map, prefix + "TaskActionCustomConfiguration", this.TaskActionCustomConfiguration);
        }
    }
}


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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWMCPRouteCheckResult : AbstractModel
    {
        
        /// <summary>
        /// <p>冲突路由ID</p>
        /// </summary>
        [JsonProperty("ConflictRouteId")]
        public string ConflictRouteId{ get; set; }

        /// <summary>
        /// <p>是否冲突</p><p>枚举值：</p><ul><li>true： 冲突</li><li>false： 未冲突</li></ul>
        /// </summary>
        [JsonProperty("IsConflict")]
        public bool? IsConflict{ get; set; }

        /// <summary>
        /// <p>冲突原因</p>
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConflictRouteId", this.ConflictRouteId);
            this.SetParamSimple(map, prefix + "IsConflict", this.IsConflict);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}


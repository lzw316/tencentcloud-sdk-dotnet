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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplicationList : AbstractModel
    {
        
        /// <summary>
        /// 应用列表
        /// </summary>
        [JsonProperty("ApplicationInfoList")]
        public ApplicationInfo[] ApplicationInfoList{ get; set; }

        /// <summary>
        /// 当前查询条件命中的数据总条数
        /// </summary>
        [JsonProperty("TotalCount")]
        public string TotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ApplicationInfoList.", this.ApplicationInfoList);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
        }
    }
}


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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BillComponent : AbstractModel
    {
        
        /// <summary>
        /// 组件类型编码
        /// </summary>
        [JsonProperty("ComponentCode")]
        public string ComponentCode{ get; set; }

        /// <summary>
        /// 组件类型：用户购买的产品或服务对应的组件大类
        /// </summary>
        [JsonProperty("ComponentCodeName")]
        public string ComponentCodeName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComponentCode", this.ComponentCode);
            this.SetParamSimple(map, prefix + "ComponentCodeName", this.ComponentCodeName);
        }
    }
}


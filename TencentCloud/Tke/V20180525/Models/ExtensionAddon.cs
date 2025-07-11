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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtensionAddon : AbstractModel
    {
        
        /// <summary>
        /// 扩展组件名称
        /// </summary>
        [JsonProperty("AddonName")]
        public string AddonName{ get; set; }

        /// <summary>
        /// 扩展组件信息(扩展组件资源对象的json字符串描述)
        /// </summary>
        [JsonProperty("AddonParam")]
        public string AddonParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddonName", this.AddonName);
            this.SetParamSimple(map, prefix + "AddonParam", this.AddonParam);
        }
    }
}


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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceFamilyTypeConfig : AbstractModel
    {
        
        /// <summary>
        /// 实例机型系列类型Id
        /// </summary>
        [JsonProperty("InstanceFamilyType")]
        public string InstanceFamilyType{ get; set; }

        /// <summary>
        /// 实例机型系列类型名称
        /// </summary>
        [JsonProperty("InstanceFamilyTypeName")]
        public string InstanceFamilyTypeName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceFamilyType", this.InstanceFamilyType);
            this.SetParamSimple(map, prefix + "InstanceFamilyTypeName", this.InstanceFamilyTypeName);
        }
    }
}


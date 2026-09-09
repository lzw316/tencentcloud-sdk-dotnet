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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemplateUserFlowType : AbstractModel
    {
        
        /// <summary>
        /// <p>合同类型id</p>
        /// </summary>
        [JsonProperty("UserFlowTypeId")]
        public string UserFlowTypeId{ get; set; }

        /// <summary>
        /// <p>合同类型名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>合同类型的具体描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>每个合同类型绑定的模板数量</p>
        /// </summary>
        [JsonProperty("TemplateNum")]
        public long? TemplateNum{ get; set; }

        /// <summary>
        /// <p>自定义合同类型状态</p><p>枚举值：</p><ul><li>0： 未启用</li><li>1： 启用</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserFlowTypeId", this.UserFlowTypeId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "TemplateNum", this.TemplateNum);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}


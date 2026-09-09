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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentPluginCredentialConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>插件鉴权值来源</p><p>枚举值：</p><ul><li>0： 未指定</li><li>1： 使用插件默认鉴权值，仅 APIKey/AccessKey 支持</li><li>2： 引用凭证</li><li>3： 引用变量</li></ul>
        /// </summary>
        [JsonProperty("AuthValueSource")]
        public long? AuthValueSource{ get; set; }

        /// <summary>
        /// <p>凭证ID</p><p>入参限制：AuthValueSource=2时必填</p>
        /// </summary>
        [JsonProperty("CredentialId")]
        public string CredentialId{ get; set; }

        /// <summary>
        /// <p>参数配置</p>
        /// </summary>
        [JsonProperty("ParamList")]
        public AgentPluginCredentialParam[] ParamList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuthValueSource", this.AuthValueSource);
            this.SetParamSimple(map, prefix + "CredentialId", this.CredentialId);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
        }
    }
}


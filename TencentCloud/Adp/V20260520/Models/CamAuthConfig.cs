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

    public class CamAuthConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>角色名称</p>
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// <p>密钥位置 HEADER/QUERY</p><p>枚举值:<br>| uint | 描述 |<br>| --- | --- |<br>| 0 | 头鉴权 |<br>| 1 | 请求信息鉴权 |</p>
        /// </summary>
        [JsonProperty("KeyLocation")]
        public long? KeyLocation{ get; set; }

        /// <summary>
        /// <p>SecretId字段名称</p>
        /// </summary>
        [JsonProperty("SecretIdName")]
        public string SecretIdName{ get; set; }

        /// <summary>
        /// <p>SecretKey字段名称</p>
        /// </summary>
        [JsonProperty("SecretKeyName")]
        public string SecretKeyName{ get; set; }

        /// <summary>
        /// <p>CAM Access Key 字段配置</p>
        /// </summary>
        [JsonProperty("ParamList")]
        public AccessKeyParamConfig[] ParamList{ get; set; }

        /// <summary>
        /// <p>是否支持CAM角色授权</p>
        /// </summary>
        [JsonProperty("SupportRoleAuth")]
        public bool? SupportRoleAuth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "KeyLocation", this.KeyLocation);
            this.SetParamSimple(map, prefix + "SecretIdName", this.SecretIdName);
            this.SetParamSimple(map, prefix + "SecretKeyName", this.SecretKeyName);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
            this.SetParamSimple(map, prefix + "SupportRoleAuth", this.SupportRoleAuth);
        }
    }
}


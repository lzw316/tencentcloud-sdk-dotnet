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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserInfo : AbstractModel
    {
        
        /// <summary>
        /// 集群实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [JsonProperty("PassWord")]
        public string PassWord{ get; set; }

        /// <summary>
        /// 用户链接来自的 IP
        /// </summary>
        [JsonProperty("WhiteHost")]
        public string WhiteHost{ get; set; }

        /// <summary>
        /// 修改前用户链接来自的 IP
        /// </summary>
        [JsonProperty("OldWhiteHost")]
        public string OldWhiteHost{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Describe")]
        public string Describe{ get; set; }

        /// <summary>
        /// 旧密码
        /// </summary>
        [JsonProperty("OldPwd")]
        public string OldPwd{ get; set; }

        /// <summary>
        /// 绑定的子用户uin
        /// </summary>
        [JsonProperty("CamUin")]
        public string CamUin{ get; set; }

        /// <summary>
        /// ranger group id列表
        /// </summary>
        [JsonProperty("CamRangerGroupIds")]
        public long?[] CamRangerGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "PassWord", this.PassWord);
            this.SetParamSimple(map, prefix + "WhiteHost", this.WhiteHost);
            this.SetParamSimple(map, prefix + "OldWhiteHost", this.OldWhiteHost);
            this.SetParamSimple(map, prefix + "Describe", this.Describe);
            this.SetParamSimple(map, prefix + "OldPwd", this.OldPwd);
            this.SetParamSimple(map, prefix + "CamUin", this.CamUin);
            this.SetParamArraySimple(map, prefix + "CamRangerGroupIds.", this.CamRangerGroupIds);
        }
    }
}


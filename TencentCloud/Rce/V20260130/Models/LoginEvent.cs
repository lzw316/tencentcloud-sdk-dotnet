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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoginEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>用户基础信息</p>
        /// </summary>
        [JsonProperty("UserInfo")]
        public User UserInfo{ get; set; }

        /// <summary>
        /// <p>用户登录时输入的用户名</p>
        /// </summary>
        [JsonProperty("UserLoginName")]
        public string UserLoginName{ get; set; }

        /// <summary>
        /// <p>登录结果</p>
        /// </summary>
        [JsonProperty("LoginResult")]
        public Result LoginResult{ get; set; }

        /// <summary>
        /// <p>用户注册时间。</p><p>参数格式：要求符合ISO 8601标准的带时区的毫秒级时间，格式&quot;YYYY-MM-DDTHH:mm:ss.sssZ&quot; ，例如&quot;2025-10-19T09:11:10.145+08:00&quot;</p>
        /// </summary>
        [JsonProperty("RegisterTime")]
        public string RegisterTime{ get; set; }

        /// <summary>
        /// <p>是否付费用户。</p><p>枚举值：</p><ul><li>true： 付费用户</li><li>false： 非付费用户</li></ul>
        /// </summary>
        [JsonProperty("IsPaidUser")]
        public bool? IsPaidUser{ get; set; }

        /// <summary>
        /// <p>与RCE约定的定制化信息，为K:V 格式的对象数组，示例：[{&quot;Key&quot;: &quot;ApproverName&quot;, &quot;Value&quot;: &quot;bob&quot;},{&quot;Key&quot;:&quot;ApproverPhone&quot;,&quot;Value&quot;: &quot;+86131****5678&quot;}]</p>
        /// </summary>
        [JsonProperty("Cust")]
        public Cust[] Cust{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamSimple(map, prefix + "UserLoginName", this.UserLoginName);
            this.SetParamObj(map, prefix + "LoginResult.", this.LoginResult);
            this.SetParamSimple(map, prefix + "RegisterTime", this.RegisterTime);
            this.SetParamSimple(map, prefix + "IsPaidUser", this.IsPaidUser);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}


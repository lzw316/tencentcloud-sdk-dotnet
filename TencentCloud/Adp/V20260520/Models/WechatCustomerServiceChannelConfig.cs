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

    public class WechatCustomerServiceChannelConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>企业微信应用Secret</p>
        /// </summary>
        [JsonProperty("AgentSecret")]
        public string AgentSecret{ get; set; }

        /// <summary>
        /// <p>头像URL</p>
        /// </summary>
        [JsonProperty("Avatar")]
        public string Avatar{ get; set; }

        /// <summary>
        /// <p>回调配置</p>
        /// </summary>
        [JsonProperty("Callback")]
        public CallbackConfig Callback{ get; set; }

        /// <summary>
        /// <p>客服账号ID</p>
        /// </summary>
        [JsonProperty("CustomerServiceId")]
        public string CustomerServiceId{ get; set; }

        /// <summary>
        /// <p>客服账号名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>客服形象二维码URL</p>
        /// </summary>
        [JsonProperty("ShareCodeUrl")]
        public string ShareCodeUrl{ get; set; }

        /// <summary>
        /// <p>企业微信企业ID</p>
        /// </summary>
        [JsonProperty("WecomCorpId")]
        public string WecomCorpId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentSecret", this.AgentSecret);
            this.SetParamSimple(map, prefix + "Avatar", this.Avatar);
            this.SetParamObj(map, prefix + "Callback.", this.Callback);
            this.SetParamSimple(map, prefix + "CustomerServiceId", this.CustomerServiceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ShareCodeUrl", this.ShareCodeUrl);
            this.SetParamSimple(map, prefix + "WecomCorpId", this.WecomCorpId);
        }
    }
}

